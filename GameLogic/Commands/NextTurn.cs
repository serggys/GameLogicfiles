namespace GameLogic.Commands
{
	public class NextTurn : Command
	{
		protected override bool Run ()
		{
			Core.Turns.NextTurn();
			return true;
		}
	}
}
