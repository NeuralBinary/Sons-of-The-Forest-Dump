using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedTerrainGrass
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[PreferBinarySerialization]
	[Serializable]
	public class DetailLayerMap
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DetailLayerMap()
		{
		}

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public byte[] mapByte;
	}
}
