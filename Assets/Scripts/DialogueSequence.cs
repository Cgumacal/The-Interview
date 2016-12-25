using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueSequence : MonoBehaviour {
    Text dialogue;
    int questionNum;
    public Button c1, c2, c3;

    string[] conversation1 = { "So, you're the new blood management was talking about, huh?"
            , "Look, I'm only asking because I wanna give you a little tip: this place is a little weird. We might be a game company, but getting in isn't as easy as you'd expect."
            , "Why don't you try talking to the other employees? They might be able to tell you something useful. Oh, and the higher ups ask some odd hypothetical questions, so just be ready to think a little bit."
            , "Alright, you little punk. I hope you get the job just so I can make your life a living hell."
    };

    string[] answer1 = {"Yep, that's me"
            , "Oh boy, that's not a good sign at all..."
            , "Thanks, I'll keep that in mind. Hope I see you up there!"
            , "Bye"
    };

    string[] answer2 = { "Definitely not. Please don't mention me to anyone."
            , "I'm sure I can handle it. I've taken two whole classes on interviews."
            , "Huh? Sorry, missed that last part. Probably wasn't important though."
            , "bye"
    };

    string[] answer3 = { "Sorta. I'm here for your job."
            , "This place is different from other places? Whoa, that's fascinating. Very insightful."
            , "Oh god, thinking? My one weakness!"
            , "bye"
    };



    // Use this for initialization
    public void Start () {
        dialogue = GetComponent<Text>();
        setQuestion(0);
        
    }

    public void choice1()
    {
        switch (questionNum)
        {
            case 0:
                setQuestion(1);
                break;
            case 1:
                setQuestion(2);
                break;
            case 2:
                EndConversation();
                break;
            case 3:
                EndConversation();
                break;
        }
    }

    public void choice2()
    {
        switch (questionNum)
        {
            case 0:
                setQuestion(1);
                break;
            case 1:
                setQuestion(2);
                break;
            case 2:
                EndConversation();
                break;
            case 3:
                EndConversation();
                break;
        }
    }

    public void choice3()
    {
        switch (questionNum)
        {
            case 0:
                setQuestion(3);
                break;
            case 1:
                setQuestion(3);
                break;
            case 2:
                EndConversation();
                break;
            case 3:
                EndConversation();
                break;
        }
    }

    void setQuestion(int num)
    {
        switch (num)
        {
            case 0:
                questionNum = 0;
                dialogue.text = conversation1[questionNum];
                c1.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer1[questionNum];
                c2.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer2[questionNum];
                c3.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer3[questionNum];
                break;
            case 1:
                questionNum = 1;
                dialogue.text = conversation1[questionNum];
                c1.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer1[questionNum];
                c2.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer2[questionNum];
                c3.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer3[questionNum];
                break;
            case 2:
                questionNum = 2;
                dialogue.text = conversation1[questionNum];
                c1.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer1[questionNum];
                c2.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer2[questionNum];
                c3.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer3[questionNum];
                break;
            case 3:
                questionNum = 3;
                dialogue.text = conversation1[questionNum];
                c1.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer1[questionNum];
                c2.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer2[questionNum];
                c3.transform.FindChild("Text").gameObject.GetComponent<Text>().text = answer3[questionNum];
                break;
        }
    }

    void EndConversation()
    {
        transform.parent.GetComponent<Canvas>().enabled = false;
        PlayerMovement.UIActive = false;
    }
}
