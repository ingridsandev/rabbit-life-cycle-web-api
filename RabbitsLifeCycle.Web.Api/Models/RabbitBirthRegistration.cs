namespace RabbitsLifeCycle.Web.Api.Models
{
    public class RabbitBirthRegistration
    {
        public RabbitBirthRegistration(int month, int bornRabbits)
        {
            Month = month;
            BornRabbits = bornRabbits;
        }

        public int Month { get; set; }

        public int BornRabbits { get; set; }

        public int MatureMonth => Month + 3;
    }
}
