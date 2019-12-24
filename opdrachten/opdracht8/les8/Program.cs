using System;

namespace les8
{
    public abstract class Winkelkar
    {
        public abstract void Ontgrendelen();
        public abstract void Rijden();
    }

        // dit schrijven en dan op lampje
        // public class PlasticKar : Winkelkar {
        // public PlasticKar() {
            
        // }
        // }

    public class PlasticKar : Winkelkar {
        public PlasticKar() {
            
        }

		public override void Ontgrendelen()
		{
			throw new NotImplementedException();
		}

		public override void Rijden()
		{
			throw new NotImplementedException();
		}
	}
}
