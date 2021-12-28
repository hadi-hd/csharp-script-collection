using UnityEngine;

namespace HadiHD
{
    public class PhysicMaterials
    {
        public static PhysicMaterial Metal
        {
            get
            {
                var _metal = new PhysicMaterial("Metal")
                {
                    dynamicFriction = 0.25F,
                    staticFriction = 0.25F,
                    bounciness = 0,
                    frictionCombine = PhysicMaterialCombine.Average,
                    bounceCombine = PhysicMaterialCombine.Average
                };
                return _metal;
            }
        }
        public static PhysicMaterial Wood
        {
            get
            {
                var _wood = new PhysicMaterial("Wood")
                {
                    dynamicFriction = 0.45F,
                    staticFriction = 0.45F,
                    bounciness = 0,
                    frictionCombine = PhysicMaterialCombine.Average,
                    bounceCombine = PhysicMaterialCombine.Average
                };
                return _wood;
            }
        }
        public static PhysicMaterial Ice
        {
            get
            {
                var _wood = new PhysicMaterial("Ice")
                {
                    dynamicFriction = 0.1F,
                    staticFriction = 0.1F,
                    bounciness = 0,
                    frictionCombine = PhysicMaterialCombine.Multiply,
                    bounceCombine = PhysicMaterialCombine.Multiply
                };
                return _wood;
            }
        }
        public static PhysicMaterial Rubber
        {
            get
            {
                var _rubber = new PhysicMaterial("Rubber")
                {
                    dynamicFriction = 1F,
                    staticFriction = 1F,
                    bounciness = 0F,
                    frictionCombine = PhysicMaterialCombine.Maximum,
                    bounceCombine = PhysicMaterialCombine.Average
                };
                return _rubber;
            }
        }
        public static PhysicMaterial Player
        {
            get
            {
                var _player = new PhysicMaterial("Player")
                {
                    dynamicFriction = 1F,
                    staticFriction = 5F,
                    bounciness = 0F,
                    frictionCombine = PhysicMaterialCombine.Average,
                    bounceCombine = PhysicMaterialCombine.Average
                };
                return _player;
            }
        }
    }
}
