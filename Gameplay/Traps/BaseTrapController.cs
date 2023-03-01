using System;
using System.Collections.Generic;
using FMOD;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Multiplayer;
using Sons.Physics;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x020006EC RID: 1772
	[Token(Token = "0x20006EC")]
	public abstract class BaseTrapController : BoltEntityBehaviourWrapper<ITrapStructureState>
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x0000D008 File Offset: 0x0000B208
		// (set) Token: 0x06002DB8 RID: 11704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A9")]
		public bool IsTriggered
		{
			[Token(Token = "0x6002DB7")]
			[Address(RVA = "0x2E036A0", Offset = "0x2E026A0", VA = "0x182E036A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002DB8")]
			[Address(RVA = "0x2E036C0", Offset = "0x2E026C0", VA = "0x182E036C0")]
			set
			{
			}
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x2E02BC0", Offset = "0x2E01BC0", VA = "0x182E02BC0", Slot = "24")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x2E02D60", Offset = "0x2E01D60", VA = "0x182E02D60", Slot = "25")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x2E03590", Offset = "0x2E02590", VA = "0x182E03590")]
		private void Start()
		{
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x2E02AF0", Offset = "0x2E01AF0", VA = "0x182E02AF0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0x2E03280", Offset = "0x2E02280", VA = "0x182E03280")]
		private void SetTriggered(bool triggered)
		{
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0x2E02F00", Offset = "0x2E01F00", VA = "0x182E02F00")]
		private void OnTrapTriggered(Collider obj)
		{
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DBF")]
		[Address(RVA = "0x2E02E80", Offset = "0x2E01E80", VA = "0x182E02E80")]
		public void OnTrapTriggeredRemotely()
		{
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x6002DC0")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "26")]
		protected virtual bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0x2E030D0", Offset = "0x2E020D0", VA = "0x182E030D0")]
		public void ResetTrapRemotely()
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0x2E03170", Offset = "0x2E02170", VA = "0x182E03170")]
		public void ResetTrap()
		{
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC3")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "27")]
		protected virtual void OnReset()
		{
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC4")]
		[Address(RVA = "0x656130", Offset = "0x655130", VA = "0x180656130")]
		public BaseTrapController.SaveData GetSerializedData()
		{
			return null;
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x2E02D40", Offset = "0x2E01D40", VA = "0x182E02D40")]
		public void DeserializeData(BaseTrapController.SaveData saveData)
		{
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x2E035D0", Offset = "0x2E025D0", VA = "0x182E035D0")]
		protected BaseTrapController()
		{
		}

		// Token: 0x040028CC RID: 10444
		[Token(Token = "0x40028CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040028CD RID: 10445
		[Token(Token = "0x40028CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ResetScrewTrap _trapReset;

		// Token: 0x040028CE RID: 10446
		[Token(Token = "0x40028CE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private OnTriggerProxy _onTriggerTrapProxy;

		// Token: 0x040028CF RID: 10447
		[Token(Token = "0x40028CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayerMask _triggerLayers;

		// Token: 0x040028D0 RID: 10448
		[Token(Token = "0x40028D0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[EventRef]
		private string _onTriggeredEvent;

		// Token: 0x040028D1 RID: 10449
		[Token(Token = "0x40028D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[EventRef]
		private string _onResetEvent;

		// Token: 0x040028D2 RID: 10450
		[Token(Token = "0x40028D2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected List<VailActorTypeId> _validActorTypes;

		// Token: 0x040028D3 RID: 10451
		[Token(Token = "0x40028D3")]
		[FieldOffset(Offset = "0x68")]
		private FMOD_AnimationEventHandler _fmodAnimationEventHandler;

		// Token: 0x040028D4 RID: 10452
		[Token(Token = "0x40028D4")]
		[FieldOffset(Offset = "0x70")]
		private readonly BaseTrapController.SaveData _saveData;

		// Token: 0x020006ED RID: 1773
		[Token(Token = "0x20006ED")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x06002DC7 RID: 11719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002DC7")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public SaveData()
			{
			}

			// Token: 0x040028D5 RID: 10453
			[Token(Token = "0x40028D5")]
			[FieldOffset(Offset = "0x10")]
			public bool IsTriggered;
		}
	}
}
