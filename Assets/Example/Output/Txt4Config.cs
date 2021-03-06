﻿using System.Collections.Generic;

[System.Serializable]
public class Txt4Config
{
    /// <summary>
    /// 测试所有类型
    /// </summary>
    public string id;

    /// <summary>
    /// 布尔
    /// </summary>
    public bool p1;

    /// <summary>
    /// uint8
    /// </summary>
    public byte p2;

    /// <summary>
    /// uint16
    /// </summary>
    public ushort p3;

    /// <summary>
    /// uint32
    /// </summary>
    public uint p4;

    /// <summary>
    /// int8
    /// </summary>
    public sbyte p5;

    /// <summary>
    /// int16
    /// </summary>
    public short p6;

    /// <summary>
    /// int32
    /// </summary>
    public int p7;

    /// <summary>
    /// long
    /// </summary>
    public long p8;

    /// <summary>
    /// ulong
    /// </summary>
    public ulong p9;

    /// <summary>
    /// float
    /// </summary>
    public float p10;

    /// <summary>
    /// double
    /// </summary>
    public double p11;

    /// <summary>
    /// string
    /// </summary>
    public string p12;

    /// <summary>
    /// int数组
    /// </summary>
    public int[] p13;

    /// <summary>
    /// uint数组
    /// </summary>
    public uint[] p14;

    /// <summary>
    /// string数组
    /// </summary>
    public string[] p15;

    /// <summary>
    /// bool数组
    /// </summary>
    public bool[] p16;


    private static Dictionary<string, Txt4Config> dictionary = new Dictionary<string, Txt4Config>();

    /// <summary>
    /// 通过id获取Txt4Config的实例
    /// </summary>
    /// <param name="id">索引</param>
    /// <returns>Txt4Config的实例</returns>
    public static Txt4Config Get(string id)
    {
        return dictionary[id];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<string, Txt4Config> GetDictionary()
    {
        return dictionary;
    }
}
