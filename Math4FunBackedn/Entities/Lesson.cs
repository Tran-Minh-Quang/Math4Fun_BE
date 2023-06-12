﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Math4FunBackedn.Entities
{
    public class Lesson
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public bool? Status { get; set; }
        public int? ExpGained { get; set; }
        [ForeignKey("ChapterId")]
        public Guid ChapterId { get; set; }
        public Chapter? Chapter { get; set; }
        public ICollection<Question>? QuestionList { get; set; }
    }
}