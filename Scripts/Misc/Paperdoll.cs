using System.Collections.Generic;
using Server.Network;

namespace Server.Misc
{
    public class Paperdoll
	{
		public static void Initialize()
		{
			EventSink.PaperdollRequest += new PaperdollRequestEventHandler( EventSink_PaperdollRequest );
		}

		public static void EventSink_PaperdollRequest( PaperdollRequestEventArgs e )
		{
			Mobile beholder = e.Beholder;
			Mobile beheld = e.Beheld;

			beholder.Send( new DisplayPaperdoll( beheld, Titles.ComputeTitle( beholder, beheld ), beheld.AllowEquipFrom( beholder ) ) );
		}
	}
}