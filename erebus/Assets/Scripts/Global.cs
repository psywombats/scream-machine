﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour {

    private static readonly string VNModulePath = "Prefabs/UI/VNModule";

    private static Global instance;
    private bool destructing;
    
    public InputManager Input { get; private set; }
    public LuaInterpreter Lua { get; private set; }
    public MapManager Maps { get; private set; }
    public MemoryManager Memory { get; private set; }
    public AudioManager Audio { get; private set; }
    public SettingsCollection Settings { get; private set; }

    private IndexDatabase database;
    public IndexDatabase Database {
        get {
            if (database == null && !destructing) {
                database = IndexDatabase.Instance();
            }
            return database;
        }
    }

    private ScenePlayer scenePlayer;
    public ScenePlayer ScenePlayer {
        get {
            if (destructing) {
                return null;
            }
            if (scenePlayer != null) {
                if (scenePlayer.gameObject.scene != SceneManager.GetActiveScene()) {
                    scenePlayer = null;
                }
            }
            if (scenePlayer == null) {
                scenePlayer = FindObjectOfType<ScenePlayer>();
            }
            if (scenePlayer == null) {
                GameObject module = Instantiate(Resources.Load<GameObject>(VNModulePath));
                scenePlayer = module.GetComponentInChildren<ScenePlayer>();
                module.transform.parent = FindObjectOfType<AvatarEvent>().VNModuleAttachmentPoint.transform;
            }
            return scenePlayer;
        }
    }

    public static Global Instance() {
        if (instance == null) {
            GameObject globalObject = new GameObject();
            // debug-ish and we don't serialize scenes
            // globalObject.hideFlags = HideFlags.HideAndDontSave;
            instance = globalObject.AddComponent<Global>();
            instance.InstantiateManagers();
        }

        // this should be the only game/engine binding
        GGlobal.Instance();

        return instance;
    }

    public void Update() {
        SetFullscreenMode();
    }

    public void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    public void OnDestroy() {
        destructing = true;
    }

    private void InstantiateManagers() {
        Settings = gameObject.AddComponent<SettingsCollection>();
        Input = gameObject.AddComponent<InputManager>();
        Lua = gameObject.AddComponent<LuaInterpreter>();
        Maps = gameObject.AddComponent<MapManager>();
        Memory = gameObject.AddComponent<MemoryManager>();
        Audio = gameObject.AddComponent<AudioManager>();
    }

    private void SetFullscreenMode() {
        // not sure if this "check" is necessary
        // actually performing this here is kind of a hack
        if (Settings != null && Screen.fullScreen != Settings.GetBoolSetting(SettingsConstants.Fullscreen).Value) {
            Screen.fullScreen = Settings.GetBoolSetting(SettingsConstants.Fullscreen).Value;
        }
    }
}
