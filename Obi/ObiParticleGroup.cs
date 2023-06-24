using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	[Serializable]
	public class ObiParticleGroup : ScriptableObject
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170000E1")]
		public ObiActorBlueprint blueprint
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetSourceBlueprint(ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x170000E2")]
		public int Count
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x27C2960", Offset = "0x27C0F60", VA = "0x1827C2960")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x27C29A0", Offset = "0x27C0FA0", VA = "0x1827C29A0")]
		public bool ContainsParticle(int index)
		{
			return default(bool);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x27C2A40", Offset = "0x27C1040", VA = "0x1827C2A40")]
		public ObiParticleGroup()
		{
		}

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x18")]
		public List<int> particleIndices;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x20")]
		public ObiActorBlueprint m_Blueprint;
	}
}
