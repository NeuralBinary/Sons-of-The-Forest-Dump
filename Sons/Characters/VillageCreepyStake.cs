using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x0200072E RID: 1838
	[Token(Token = "0x200072E")]
	[AddComponentMenu("Sons/Characters/VillageCreepyStake")]
	public class VillageCreepyStake : VillageObject
	{
		// Token: 0x06003128 RID: 12584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x3485150", Offset = "0x3483750", VA = "0x183485150")]
		private VillageCreepyStake.StakeData GetData()
		{
			return null;
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003129")]
		[Address(RVA = "0x3485190", Offset = "0x3483790", VA = "0x183485190")]
		private void ChangedType()
		{
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x3485380", Offset = "0x3483980", VA = "0x183485380")]
		private void Start()
		{
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x0000EF70 File Offset: 0x0000D170
		[Token(Token = "0x17000676")]
		private bool IsOfflineOrServer
		{
			[Token(Token = "0x600312B")]
			[Address(RVA = "0x3485440", Offset = "0x3483A40", VA = "0x183485440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312C")]
		[Address(RVA = "0x34854E0", Offset = "0x3483AE0", VA = "0x1834854E0", Slot = "4")]
		public override void ShowObject(bool value, bool networkRep)
		{
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312D")]
		[Address(RVA = "0x3485520", Offset = "0x3483B20", VA = "0x183485520")]
		public void BreakCallback()
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312E")]
		[Address(RVA = "0x3485560", Offset = "0x3483B60", VA = "0x183485560", Slot = "5")]
		public override void OnStateFlagsSet(VillageManager.ObjectFlags flags, bool isLoad)
		{
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312F")]
		[Address(RVA = "0x3485680", Offset = "0x3483C80", VA = "0x183485680")]
		private void OnBreakRopeFlagSet(bool isLoad)
		{
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003130")]
		[Address(RVA = "0x3485810", Offset = "0x3483E10", VA = "0x183485810")]
		public void FreeCreepyServer()
		{
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003131")]
		[Address(RVA = "0x3485840", Offset = "0x3483E40", VA = "0x183485840")]
		private void FreeCreepy()
		{
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003132")]
		[Address(RVA = "0x3485B70", Offset = "0x3484170", VA = "0x183485B70")]
		private void BreakRopeTest()
		{
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003133")]
		[Address(RVA = "0x3485B80", Offset = "0x3484180", VA = "0x183485B80")]
		private void SpawnCreepy()
		{
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x3485FA0", Offset = "0x34845A0", VA = "0x183485FA0")]
		public void OnShow()
		{
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003135")]
		[Address(RVA = "0x3486130", Offset = "0x3484730", VA = "0x183486130")]
		public void OnHide()
		{
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003136")]
		[Address(RVA = "0x3486350", Offset = "0x3484950", VA = "0x183486350")]
		public VillageCreepyStake()
		{
		}

		// Token: 0x04002A72 RID: 10866
		[Token(Token = "0x4002A72")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VillageCreepyStake.StakeType _stakeType;

		// Token: 0x04002A73 RID: 10867
		[Token(Token = "0x4002A73")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private VillageCreepyStake.StakeData[] _stakeDatas;

		// Token: 0x04002A74 RID: 10868
		[Token(Token = "0x4002A74")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private EventStimuli _onFreeEvent;

		// Token: 0x04002A75 RID: 10869
		[Token(Token = "0x4002A75")]
		[FieldOffset(Offset = "0xC0")]
		private WorldSimActor _spawnedWorldActor;

		// Token: 0x0200072F RID: 1839
		[Token(Token = "0x200072F")]
		private enum StakeType
		{
			// Token: 0x04002A77 RID: 10871
			[Token(Token = "0x4002A77")]
			Puffy,
			// Token: 0x04002A78 RID: 10872
			[Token(Token = "0x4002A78")]
			Fingers
		}

		// Token: 0x02000730 RID: 1840
		[Token(Token = "0x2000730")]
		[Serializable]
		private class StakeData
		{
			// Token: 0x06003137 RID: 12599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003137")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public StakeData()
			{
			}

			// Token: 0x04002A79 RID: 10873
			[Token(Token = "0x4002A79")]
			[FieldOffset(Offset = "0x10")]
			public CharacterDefinition _characterDefinition;

			// Token: 0x04002A7A RID: 10874
			[Token(Token = "0x4002A7A")]
			[FieldOffset(Offset = "0x18")]
			public WorldSimController _worldControllerOverride;

			// Token: 0x04002A7B RID: 10875
			[Token(Token = "0x4002A7B")]
			[FieldOffset(Offset = "0x20")]
			public BreakableObject _breakableRope;

			// Token: 0x04002A7C RID: 10876
			[Token(Token = "0x4002A7C")]
			[FieldOffset(Offset = "0x28")]
			public Transform _spawnPoint;
		}
	}
}
