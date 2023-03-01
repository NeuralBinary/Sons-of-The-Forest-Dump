using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.TerrainDetail
{
	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x2000502")]
	[Serializable]
	public class KeyedWorldObjectLocatorGroup
	{
		// Token: 0x060020BA RID: 8378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x87BC70", Offset = "0x87AC70", VA = "0x18087BC70")]
		public KeyedWorldObjectLocatorGroup(GroupDefinition key, WorldObjectLocatorGroup value)
		{
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000484")]
		public GroupDefinition Key
		{
			[Token(Token = "0x60020BB")]
			[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000485")]
		public WorldObjectLocatorGroup Value
		{
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x17000486")]
		public bool IsOpen
		{
			[Token(Token = "0x60020BD")]
			[Address(RVA = "0x2D2AAD0", Offset = "0x2D29AD0", VA = "0x182D2AAD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("Key")]
		[SerializeField]
		private GroupDefinition _key;

		// Token: 0x04001E76 RID: 7798
		[Token(Token = "0x4001E76")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("Value")]
		[SerializeField]
		private WorldObjectLocatorGroup _value;
	}
}
