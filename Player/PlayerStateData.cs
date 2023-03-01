using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Settings;
using UnityEngine;

namespace Sons.Player
{
	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	[Serializable]
	public class PlayerStateData
	{
		// Token: 0x06003108 RID: 12552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003108")]
		[Address(RVA = "0x2E51460", Offset = "0x2E50460", VA = "0x182E51460")]
		public PersistentValue GetEntry(string key)
		{
			return null;
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003109")]
		[Address(RVA = "0x2E513B0", Offset = "0x2E503B0", VA = "0x182E513B0")]
		public void Add(PersistentValue newEntry)
		{
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600310A")]
		[Address(RVA = "0x2E515B0", Offset = "0x2E505B0", VA = "0x182E515B0")]
		public PlayerStateData()
		{
		}

		// Token: 0x04002ACF RID: 10959
		[Token(Token = "0x4002ACF")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty]
		[SerializeField]
		private List<PersistentValue> _entries;
	}
}
