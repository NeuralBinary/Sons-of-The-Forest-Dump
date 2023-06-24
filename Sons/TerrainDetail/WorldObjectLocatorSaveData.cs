using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.TerrainDetail
{
	// Token: 0x0200051E RID: 1310
	[Token(Token = "0x200051E")]
	[Serializable]
	public class WorldObjectLocatorSaveData
	{
		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B7")]
		[JsonProperty]
		private List<KeyValuePair<WorldLocatorId, WorldObjectState>> SerializedStates
		{
			[Token(Token = "0x60022D7")]
			[Address(RVA = "0x33465B0", Offset = "0x3344BB0", VA = "0x1833465B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022D8")]
			[Address(RVA = "0x3346670", Offset = "0x3344C70", VA = "0x183346670")]
			set
			{
			}
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public IReadOnlyDictionary<WorldLocatorId, WorldObjectState> GetStates()
		{
			return null;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DA")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public IReadOnlyDictionary<WorldLocatorId, WorldObjectState> GetUnappliedStates()
		{
			return null;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B8")]
		public string SerializedName
		{
			[Token(Token = "0x60022DB")]
			[Address(RVA = "0x3346A60", Offset = "0x3345060", VA = "0x183346A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x170004B9")]
		public bool UniqueFile
		{
			[Token(Token = "0x60022DC")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x3346A90", Offset = "0x3345090", VA = "0x183346A90")]
		[JsonConstructor]
		public WorldObjectLocatorSaveData(List<KeyValuePair<WorldLocatorId, WorldObjectState>> jsonData)
		{
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x3346C50", Offset = "0x3345250", VA = "0x183346C50")]
		public WorldObjectLocatorSaveData()
		{
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public WorldObjectLocatorSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x3346DF0", Offset = "0x33453F0", VA = "0x183346DF0")]
		public void OnDeserialize(WorldObjectLocatorManager manager)
		{
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x3346E20", Offset = "0x3345420", VA = "0x183346E20")]
		public void UpdateUnappliedState(WorldLocatorId uniqueId, WorldObjectState newState)
		{
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x3346F50", Offset = "0x3345550", VA = "0x183346F50")]
		public void UpdateState(WorldLocatorId uniqueId, WorldObjectState newState)
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x33470E0", Offset = "0x33456E0", VA = "0x1833470E0")]
		private void RemoveState(WorldLocatorId uniqueId)
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x3347170", Offset = "0x3345770", VA = "0x183347170")]
		public bool TryGetUnappliedState(WorldObjectLocator locator, out WorldObjectState state)
		{
			return default(bool);
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x3347230", Offset = "0x3345830", VA = "0x183347230")]
		public void RemoveFilteredStates()
		{
		}

		// Token: 0x04001FBE RID: 8126
		[Token(Token = "0x4001FBE")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x04001FBF RID: 8127
		[Token(Token = "0x4001FBF")]
		[FieldOffset(Offset = "0x18")]
		[JsonIgnore]
		private Dictionary<WorldLocatorId, WorldObjectState> _states;

		// Token: 0x04001FC0 RID: 8128
		[Token(Token = "0x4001FC0")]
		[FieldOffset(Offset = "0x20")]
		[JsonIgnore]
		private Dictionary<WorldLocatorId, WorldObjectState> _unappliedStates;

		// Token: 0x04001FC1 RID: 8129
		[Token(Token = "0x4001FC1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly WorldObjectState[] ValidDeserializedStates;
	}
}
