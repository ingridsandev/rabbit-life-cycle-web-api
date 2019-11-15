namespace RabbitsLifeCycle.Web.Api.Models
{
    public class RabbitBirthRegistration
    {
        public RabbitBirthRegistration(int month, long bornRabbits)
        {
            Month = month;
            BornRabbits = bornRabbits;
        }

        public int Month { get; set; }

        public long BornRabbits { get; set; }

        public int MatureMonth => Month + 3;
    }
}
