using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.TerrainDetail
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	[Serializable]
	public class KeyedWorldObjectLocatorGroup
	{
		// Token: 0x0600217D RID: 8573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600217D")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public KeyedWorldObjectLocatorGroup(GroupDefinition key, WorldObjectLocatorGroup value)
		{
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000497")]
		public GroupDefinition Key
		{
			[Token(Token = "0x600217E")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000498")]
		public WorldObjectLocatorGroup Value
		{
			[Token(Token = "0x600217F")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x17000499")]
		public bool IsOpen
		{
			[Token(Token = "0x6002180")]
			[Address(RVA = "0x3329380", Offset = "0x3327980", VA = "0x183329380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04001F0D RID: 7949
		[Token(Token = "0x4001F0D")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("Key")]
		[SerializeField]
		private GroupDefinition _key;

		// Token: 0x04001F0E RID: 7950
		[Token(Token = "0x4001F0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("Value")]
		private WorldObjectLocatorGroup _value;
	}
}
