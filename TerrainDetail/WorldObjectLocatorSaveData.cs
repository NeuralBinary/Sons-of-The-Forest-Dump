using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.TerrainDetail
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	[Serializable]
	public class WorldObjectLocatorSaveData
	{
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A3")]
		[JsonProperty]
		private List<KeyValuePair<WorldLocatorId, WorldObjectState>> SerializedStates
		{
			[Token(Token = "0x60021EC")]
			[Address(RVA = "0x2D7B040", Offset = "0x2D7A040", VA = "0x182D7B040")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021ED")]
			[Address(RVA = "0x2D7B080", Offset = "0x2D7A080", VA = "0x182D7B080")]
			set
			{
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A4")]
		public string SerializedName
		{
			[Token(Token = "0x60021EE")]
			[Address(RVA = "0x2D7B010", Offset = "0x2D7A010", VA = "0x182D7B010")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x170004A5")]
		public bool UniqueFile
		{
			[Token(Token = "0x60021EF")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F0")]
		[Address(RVA = "0x2D7AF20", Offset = "0x2D79F20", VA = "0x182D7AF20")]
		[JsonConstructor]
		public WorldObjectLocatorSaveData(List<KeyValuePair<WorldLocatorId, WorldObjectState>> jsonData)
		{
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F1")]
		[Address(RVA = "0x2D7AE50", Offset = "0x2D79E50", VA = "0x182D7AE50")]
		public WorldObjectLocatorSaveData()
		{
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x671880", Offset = "0x670880", VA = "0x180671880")]
		public WorldObjectLocatorSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x2D7A730", Offset = "0x2D79730", VA = "0x182D7A730")]
		public void OnDeserialize(WorldObjectLocatorManager manager)
		{
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x2D7ACF0", Offset = "0x2D79CF0", VA = "0x182D7ACF0")]
		public void UpdateUnappliedState(WorldLocatorId uniqueId, WorldObjectState newState)
		{
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x2D7ABB0", Offset = "0x2D79BB0", VA = "0x182D7ABB0")]
		public void UpdateState(WorldLocatorId uniqueId, WorldObjectState newState)
		{
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x2D7AA70", Offset = "0x2D79A70", VA = "0x182D7AA70")]
		private void RemoveState(WorldLocatorId uniqueId)
		{
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x2D7AAF0", Offset = "0x2D79AF0", VA = "0x182D7AAF0")]
		public bool TryGetUnappliedState(WorldObjectLocator locator, out WorldObjectState state)
		{
			return default(bool);
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x2D7A760", Offset = "0x2D79760", VA = "0x182D7A760")]
		public void RemoveFilteredStates()
		{
		}

		// Token: 0x04001F0A RID: 7946
		[Token(Token = "0x4001F0A")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x04001F0B RID: 7947
		[Token(Token = "0x4001F0B")]
		[FieldOffset(Offset = "0x18")]
		[JsonIgnore]
		private Dictionary<WorldLocatorId, WorldObjectState> _states;

		// Token: 0x04001F0C RID: 7948
		[Token(Token = "0x4001F0C")]
		[FieldOffset(Offset = "0x20")]
		[JsonIgnore]
		private Dictionary<WorldLocatorId, WorldObjectState> _unappliedStates;

		// Token: 0x04001F0D RID: 7949
		[Token(Token = "0x4001F0D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly WorldObjectState[] ValidDeserializedStates;
	}
}
