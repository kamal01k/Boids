//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public ContainedInCellComponent containedInCell { get { return (ContainedInCellComponent)GetComponent(BoidsComponentIds.ContainedInCell); } }
        public bool hasContainedInCell { get { return HasComponent(BoidsComponentIds.ContainedInCell); } }

        public Entity AddContainedInCell(Entitas.Entity newContainedInCell) {
            var component = CreateComponent<ContainedInCellComponent>(BoidsComponentIds.ContainedInCell);
            component.ContainedInCell = newContainedInCell;
            return AddComponent(BoidsComponentIds.ContainedInCell, component);
        }

        public Entity ReplaceContainedInCell(Entitas.Entity newContainedInCell) {
            var component = CreateComponent<ContainedInCellComponent>(BoidsComponentIds.ContainedInCell);
            component.ContainedInCell = newContainedInCell;
            ReplaceComponent(BoidsComponentIds.ContainedInCell, component);
            return this;
        }

        public Entity RemoveContainedInCell() {
            return RemoveComponent(BoidsComponentIds.ContainedInCell);
        }
    }
}

    public partial class BoidsMatcher {

        static IMatcher _matcherContainedInCell;

        public static IMatcher ContainedInCell {
            get {
                if(_matcherContainedInCell == null) {
                    var matcher = (Matcher)Matcher.AllOf(BoidsComponentIds.ContainedInCell);
                    matcher.componentNames = BoidsComponentIds.componentNames;
                    _matcherContainedInCell = matcher;
                }

                return _matcherContainedInCell;
            }
        }
    }
