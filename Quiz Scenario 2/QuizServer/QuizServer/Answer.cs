﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizServer
{
    public sealed class Answer
    {
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        public bool CorrectAnswer { get; set; }

        public bool PlayerAnswer { get; set; }
    }
}
