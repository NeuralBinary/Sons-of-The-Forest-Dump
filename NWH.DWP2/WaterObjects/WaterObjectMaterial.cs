using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[CreateAssetMenu(fileName = "WaterObjectMaterial", menuName = "Dynamic Water Physics 2/Water Object Material", order = 0)]
	public class WaterObjectMaterial : ScriptableObject
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x27091E0", Offset = "0x27077E0", VA = "0x1827091E0")]
		public WaterObjectMaterial()
		{
		}

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x18")]
		public float density;
	}
}
