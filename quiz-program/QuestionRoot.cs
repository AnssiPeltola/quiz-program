﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_program
{
    public class QuestionRoot
    {
        [JsonProperty("kysymykset")]
        public List<Question> Questions { get; set; }
    }
}