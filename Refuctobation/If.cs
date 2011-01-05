namespace Refuctobation
{
    public class If : Handler<GoldenSyrup>
    {
        public override void Do(GoldenSyrup message)
        {
            if (message.ireallylikerabbits())
            {
                message.isGreenish();

                return;
            }

            message.maybetomorrowiwillfeelbetter();
        }
    }
}