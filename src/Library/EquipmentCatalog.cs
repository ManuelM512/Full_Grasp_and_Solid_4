namespace Full_GRASP_And_SOLID;
using System.Collections.Generic;
using System.Linq;
public class EquipmentCatalog : ICatalog
{
    List<Equipment> equipmentCatalog;
    public EquipmentCatalog(){
        equipmentCatalog = new List<Equipment>();
    }
    public void Add(string description, int hourlyCost){
        Equipment e = new Equipment(description, hourlyCost);
        equipmentCatalog.Add(e);
    }

    public Equipment GetEquipment(string description){
        var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
        return query.FirstOrDefault();
    }

    public Equipment EquipmentAt(int index)
    {
        return equipmentCatalog[index] as Equipment;
    }
}