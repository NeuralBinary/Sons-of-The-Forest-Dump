using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Prefabs
{
	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	[Serializable]
	public class PrefabDefinition
	{
		// Token: 0x0600236B RID: 9067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x334DAB0", Offset = "0x334C0B0", VA = "0x18334DAB0")]
		public bool TryCreateInstance(Vector3 location, out GameObject newInstance)
		{
			return default(bool);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x334DAF0", Offset = "0x334C0F0", VA = "0x18334DAF0")]
		private bool TryCreateInstance(GameObject source, Vector3 location, out GameObject newInstance)
		{
			return default(bool);
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PrefabDefinition()
		{
		}

		// Token: 0x04002001 RID: 8193
		[Token(Token = "0x4002001")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x04002002 RID: 8194
		[Token(Token = "0x4002002")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _prefab;
	}
}
