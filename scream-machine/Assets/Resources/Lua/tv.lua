if getSwitch('day_4') then
    speak("Television", "A broadcast is on TV. A panel of experts is discussing shortwave radio anomalies having a negative effect on communication infrastructure.")
if getSwitch('day_3') then
    speak("Television", "A news broadcast is on TV. A panel of experts is discussing the one year anniversary of the Mission St. disappearances and the lack of leads.")
elseif getSwitch('saw_vhs') then
    speak("Television", "With the tape ended, only static remains on the screen.")
elseif getSwitch('vcr_mode') then
    speak("VCR", "Upon inserting the tape, a recording begins to play. A man is speaking directly into the camera.")
    wait(0.8)
    speak("Man", "Greetings my students, and welcome to Ad Astra. I'm speaking to you today as a representative of the Heavenly Father, and while I still might be a mere shell myself, I hope I can answer your questions and help guide to a better understanding of His plan.")
    speak("Man", "I assume you already know that I stand before you in fulfilment the two thousand years of prophecy that have come before. I'm not up to the task. But as the current representive of His astral will on earth, I will try to convey to you a summary of the next level of consciousness.")
    speak("Man", "The Ad Astra series is intended only for students above the Lepus level, the septenarians. I'm afraid if you've yet to reach this level of understanding of the Plan, what I say tonight may only serve to confuse you.")
    speak("Man", "In tonight's lecture, what I want to emphasize to you, above all else, is the concept of transcendence. We call it ascendance? In the east, the boddhisvatas call it Enlightenment.")
    speak("Man", "I myself have achieved this level of understanding. And by some intrigue in His plan, some cosmic fluke, I have been sent back to this shell of mine, to this fake Earth. I believe that this was for your sake, my students.")
    speak("Man", "Having glimpsed that purest reality, that classroom set in the heavens where the forge of creation once dwelt... I only hope to convey to you a glimpse of that transcendant reality.")
    speak("Man", "How many of us here today have not experienced doubts, setbacks, obstacles in the course of carrying out His plan?")
    speak("Man", "All of us?")
    speak("Man", "And how many can say that we truly understand His plan for this plane?")
    speak("Man", "None of us?")
    speak("Man", "That, of course, that is the crux of my lecture.")
    speak("Man", "Yesterday, as I witnessed the first solar eclipse of His new millenium, I thought, and I realized...")
    speak("Man", "Disease-by-mail, power-failure, solar-storm, eternity-war, the thousand harbingers of a neomillenial-age...")
    speak("Man", "His Plan had become inscrutable and far less clear.")
    speak("Man", "That we occupy these mortal shells is a sign of our incomplete understanding. As His vessel did two thousand years ago and as I do now, we must see these shells as what they are: shackles on our sapience, mere speedbumps in the road that is the transhuman exit from this earth.")
    speak("Man", "A student once asked me: Why do bad things happen to good people?")
    speak("Man", "And I answereed: I cannot know, only He can know, for it is part of His plan.")
    speak("Man", "A student once asked me: Why must we suffer in these shells, when the kingdom of the heavens is at hand?")
    speak("Man", "And I answered: We cannot know, only He can know, for we are only cogs in the Grand Machine, the Truth, the Gestalt, the Split Second Instant Of Truth.")
    speak("Man", "Follow the Plan. Find the answers to this riddle of stars, soul, sentience, the satanic doubt that lurks at the heart of every man and his impure shell.")
    speak("Man", "Believe in life after death. That your memories, consciousness, will live on. As above, so below. May his Plan be carried out on earth as it is in the heavens.")
    wait(0.8)
    speak("VCR", "The tape reaches the end with a click.")
    setSwitch('saw_vhs', true)
    setNextScript('control/2_16', false, 5)
elseif getSwitch('day2') then
    speak("Television", "A news broadcast is on TV. An expert sociologist is discussing possible explanations for the decline in foot traffic on city streets.")
else
    speak("Television", "A talkshow rerun is on TV. A panel of experts is discussing a lawsuit against one of the city energy providers, claiming they haven't done enough to prevent the recent string of blackouts.")
end
