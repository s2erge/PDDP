﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PDDP {

    [System.Serializable]
    public struct Challenge {
        public int uuid;
        public Sprite icon;
        public string name;
        public string desc;
        public List<Answer> answers;
        public Status status;
    } // Struct Challenge

} // Namespace PDDP