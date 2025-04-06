using System;
using System.Collections;
using System.Collections.ObjectModel;
using UnityEngine;

public class ArrayListExircise : MonoBehaviour
{
    private void Awake()
    {
        ArrayList arrayList= new ArrayList();

        Debug.Log(arrayList.Add(10));

        PrintArrayList(arrayList);

        arrayList.Insert(1, 100);

        PrintArrayList(arrayList);

        Collection<int>data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        PrintArrayList(arrayList);

        arrayList.Sort();

        PrintArrayList(arrayList);

        arrayList.Remove(10);

        PrintArrayList(arrayList);

        arrayList.RemoveAt(0);

        PrintArrayList(arrayList);

        arrayList.RemoveRange(0,2);

        PrintArrayList(arrayList);

        arrayList.Clear();

        Debug.Log(arrayList.Count);
    }

    private void PrintArrayList(ArrayList arrayList)
    {
        throw new NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
