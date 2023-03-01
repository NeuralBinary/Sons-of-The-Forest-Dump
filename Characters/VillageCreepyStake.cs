using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x0200081B RID: 2075
	[Token(Token = "0x200081B")]
	[AddComponentMenu("Sons/Characters/VillageCreepyStake")]
	public class VillageCreepyStake : VillageObject
	{
		// Token: 0x06003745 RID: 14149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x2EC05D0", Offset = "0x2EBF5D0", VA = "0x182EC05D0")]
		private VillageCreepyStake.StakeData GetData()
		{
			return null;
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003746")]
		[Address(RVA = "0x2EC0260", Offset = "0x2EBF260", VA = "0x182EC0260")]
		private void ChangedType()
		{
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003747")]
		[Address(RVA = "0x2EC11B0", Offset = "0x2EC01B0", VA = "0x182EC11B0")]
		private void Start()
		{
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x00010338 File Offset: 0x0000E538
		[Token(Token = "0x170006FE")]
		private bool IsOfflineOrServer
		{
			[Token(Token = "0x6003748")]
			[Address(RVA = "0x2EC12B0", Offset = "0x2EC02B0", VA = "0x182EC12B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x2EC0A80", Offset = "0x2EBFA80", VA = "0x182EC0A80", Slot = "4")]
		public override void ShowObject(bool value, bool networkRep)
		{
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x2EC01C0", Offset = "0x2EBF1C0", VA = "0x182EC01C0")]
		public void BreakCallback()
		{
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x2EC0A30", Offset = "0x2EBFA30", VA = "0x182EC0A30", Slot = "5")]
		public override void OnStateFlagsSet(VillageManager.ObjectFlags flags, bool isLoad)
		{
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374C")]
		[Address(RVA = "0x2EC0610", Offset = "0x2EBF610", VA = "0x182EC0610")]
		private void OnBreakRopeFlagSet(bool isLoad)
		{
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374D")]
		[Address(RVA = "0x2EC0330", Offset = "0x2EBF330", VA = "0x182EC0330")]
		public void FreeCreepyServer()
		{
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374E")]
		[Address(RVA = "0x2EC0360", Offset = "0x2EBF360", VA = "0x182EC0360")]
		private void FreeCreepy()
		{
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x2EC0250", Offset = "0x2EBF250", VA = "0x182EC0250")]
		private void BreakRopeTest()
		{
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003750")]
		[Address(RVA = "0x2EC0E80", Offset = "0x2EBFE80", VA = "0x182EC0E80")]
		private void SpawnCreepy()
		{
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003751")]
		[Address(RVA = "0x2EC08B0", Offset = "0x2EBF8B0", VA = "0x182EC08B0")]
		public void OnShow()
		{
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003752")]
		[Address(RVA = "0x2EC0750", Offset = "0x2EBF750", VA = "0x182EC0750")]
		public void OnHide()
		{
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x2EC1270", Offset = "0x2EC0270", VA = "0x182EC1270")]
		public VillageCreepyStake()
		{
		}

		// Token: 0x04002F56 RID: 12118
		[Token(Token = "0x4002F56")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VillageCreepyStake.StakeType _stakeType;

		// Token: 0x04002F57 RID: 12119
		[Token(Token = "0x4002F57")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private VillageCreepyStake.StakeData[] _stakeDatas;

		// Token: 0x04002F58 RID: 12120
		[Token(Token = "0x4002F58")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private EventStimuli _onFreeEvent;

		// Token: 0x04002F59 RID: 12121
		[Token(Token = "0x4002F59")]
		[FieldOffset(Offset = "0xC0")]
		private WorldSimActor _spawnedWorldActor;

		// Token: 0x0200081C RID: 2076
		[Token(Token = "0x200081C")]
		private enum StakeType
		{
			// Token: 0x04002F5B RID: 12123
			[Token(Token = "0x4002F5B")]
			Puffy,
			// Token: 0x04002F5C RID: 12124
			[Token(Token = "0x4002F5C")]
			Fingers
		}

		// Token: 0x0200081D RID: 2077
		[Token(Token = "0x200081D")]
		[Serializable]
		private class StakeData
		{
			// Token: 0x06003754 RID: 14164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003754")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public StakeData()
			{
			}

			// Token: 0x04002F5D RID: 12125
			[Token(Token = "0x4002F5D")]
			[FieldOffset(Offset = "0x10")]
			public CharacterDefinition _characterDefinition;

			// Token: 0x04002F5E RID: 12126
			[Token(Token = "0x4002F5E")]
			[FieldOffset(Offset = "0x18")]
			public WorldSimController _worldControllerOverride;

			// Token: 0x04002F5F RID: 12127
			[Token(Token = "0x4002F5F")]
			[FieldOffset(Offset = "0x20")]
			public BreakableObject _breakableRope;

			// Token: 0x04002F60 RID: 12128
			[Token(Token = "0x4002F60")]
			[FieldOffset(Offset = "0x28")]
			public Transform _spawnPoint;
		}
	}
}
