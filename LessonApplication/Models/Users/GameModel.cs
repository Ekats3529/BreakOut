using System;

namespace LessonApplication.Models.Users
{
    public class GameModel
    {
        public int Id { get; set; }
        public DateTime PlayingDate { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }

    }
}
