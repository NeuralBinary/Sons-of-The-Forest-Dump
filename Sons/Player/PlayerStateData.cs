using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Save;
using Sons.Settings;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	[Serializable]
	public class PlayerStateData
	{
		// Token: 0x06002A7D RID: 10877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x33FC840", Offset = "0x33FAE40", VA = "0x1833FC840")]
		public PersistentValue GetEntry(string key)
		{
			return null;
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x33FC9A0", Offset = "0x33FAFA0", VA = "0x1833FC9A0")]
		public void Add(PersistentValue newEntry)
		{
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x33FCA40", Offset = "0x33FB040", VA = "0x1833FCA40")]
		public PlayerStateData()
		{
		}

		// Token: 0x0400259F RID: 9631
		[Token(Token = "0x400259F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[JsonProperty]
		private List<PersistentValue> _entries;

		// Token: 0x040025A0 RID: 9632
		[Token(Token = "0x40025A0")]
		[FieldOffset(Offset = "0x18")]
		public List<NamedIntData> NamedInts;
	}
}
