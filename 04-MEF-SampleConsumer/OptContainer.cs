using System.ComponentModel.Composition;
using _04_MEF_Opt;
using System.ComponentModel.Composition.Hosting;

namespace _04_MEF_Opt.App
{
    class OptContainer
    {
        [Import(typeof(IOpt))]
        public IOpt Opt { get; set; }

        public OptContainer()
        {
            DirectoryCatalog catalog = new DirectoryCatalog("Plugins");
            CompositionContainer container = new CompositionContainer(catalog);
            CompositionBatch batch = new CompositionBatch();
            batch.AddPart(this);
            container.Compose(batch);
        }
    }
}