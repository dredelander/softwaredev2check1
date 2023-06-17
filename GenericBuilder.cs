using System;
using System.Collections.Generic;
namespace Software2KnowledgeCheck1
{
	public class GenericBuilder<T>
    {
        public List<T> Construction = new List<T>();

        public void CreateConstruction(T construction)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<T>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                Construction.Add(construction);
            }
        }
        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning)
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public GenericBuilder()
		{
		}
	}
}

