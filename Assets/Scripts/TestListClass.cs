using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple business object. A PartId is used to identify the type of part
// but the part name can change.
public class Part : IEquatable<Part>
{
    public string PartName { get; set; }

    public int PartId { get; set; }

    public override string ToString()
    {
        return "ID: " + PartId + "   Name: " + PartName;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        Part objAsPart = obj as Part;
        if (objAsPart == null)
        {
            return false;
        }
        else
        {
            return Equals(objAsPart);
        }
    }

    public override int GetHashCode()
    {
        return PartId;
    }

    public bool Equals(Part other)
    {
        if (other == null)
        {
            return false;
        }

        return (this.PartId.Equals(other.PartId));
    }
    // Should also override == and != operators.
}

public class TestListClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestList();
    }

    void TestList()
    {
        // Create a list of parts.
        List<Part> parts = new List<Part>();

        // Add parts to the list.
        parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
        parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
        parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
        parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
        parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
        parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

        // Write out the parts in the list. This will call the overridden ToString method
        // in the Part class.        
        foreach (Part aPart in parts)
        {
            Debug.Log(aPart);
        }

        // Check the list for part #1734. This calls the IEquatable.Equals method
        // of the Part class, which checks the PartId for equality.
        Debug.Log($"Contains(\"1734\"): {parts.Contains(new Part { PartId = 1734, PartName = "" })}");

        // Insert a new item at position 2.
        Debug.Log($"Insert(2, \"1834\")");
        parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

        foreach (Part aPart in parts)
        {
            Debug.Log(aPart);
        }

        Debug.Log($"Parts[3]: {parts[3]}");
        Debug.Log("Remove(\"1534\")");
        // This will remove part 1534 even though the PartName is different,
        // because the Equals method only checks PartId for equality.
        parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

        foreach (Part aPart in parts)
        {
            Debug.Log(aPart);
        }
        Debug.Log("RemoveAt(3)");
        // This will remove the part at index 3.
        parts.RemoveAt(3);

        foreach (Part aPart in parts)
        {
            Debug.Log(aPart);
        }
    }
}
