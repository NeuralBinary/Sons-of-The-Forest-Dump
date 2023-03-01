using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Prefabs
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	[Serializable]
	public class PrefabDefinition
	{
		// Token: 0x0600227E RID: 8830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227E")]
		[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x600227F")]
		[Address(RVA = "0x2D64B20", Offset = "0x2D63B20", VA = "0x182D64B20")]
		public bool TryCreateInstance(Vector3 location, out GameObject newInstance)
		{
			return default(bool);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x2D64C60", Offset = "0x2D63C60", VA = "0x182D64C60")]
		private bool TryCreateInstance(GameObject source, Vector3 location, out GameObject newInstance)
		{
			return default(bool);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002281")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public PrefabDefinition()
		{
		}

		// Token: 0x04001F4D RID: 8013
		[Token(Token = "0x4001F4D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x04001F4E RID: 8014
		[Token(Token = "0x4001F4E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _prefab;
	}
}
