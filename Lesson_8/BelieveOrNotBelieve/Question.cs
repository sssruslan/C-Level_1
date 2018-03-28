using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve
{
    // Класс для вопроса
    [Serializable]
    public class Question
    {
        string text; // Текст вопроса
        bool trueFalse;// Правда или нет

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public bool TrueFalse
        {
            get { return trueFalse; }
            set { trueFalse = value; }
        }

        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }
}
