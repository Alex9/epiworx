﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Epiworx.Data;

namespace Epiworx.WcfRestService
{
    public class NoteData
    {
        public int NoteId { get; set; }
        public string Body { get; set; }
        public UserData CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public NoteData()
        {
        }

        public NoteData(Note note)
            : this()
        {
            if (note == null)
            {
                return;
            }

            this.NoteId = note.NoteId;
            this.Body = note.Body;
            this.CreatedBy = new UserData(note.CreatedByUser);
            this.CreatedDate = note.CreatedDate;
        }
    }
}