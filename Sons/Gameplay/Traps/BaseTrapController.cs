using System;
using System.Collections.Generic;
using FMOD;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Multiplayer;
using Sons.Physics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.Traps
{
	// Token: 0x02000839 RID: 2105
	[Token(Token = "0x2000839")]
	public abstract class BaseTrapController : BoltEntityBehaviourWrapper<ITrapStructureState>
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x00012258 File Offset: 0x00010458
		// (set) Token: 0x06003BA4 RID: 15268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007AC")]
		public bool IsTriggered
		{
			[Token(Token = "0x6003BA3")]
			[Address(RVA = "0x35923C0", Offset = "0x35909C0", VA = "0x1835923C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BA4")]
			[Address(RVA = "0x35923E0", Offset = "0x35909E0", VA = "0x1835923E0")]
			set
			{
			}
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA5")]
		[Address(RVA = "0x3592400", Offset = "0x3590A00", VA = "0x183592400", Slot = "24")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA6")]
		[Address(RVA = "0x3592560", Offset = "0x3590B60", VA = "0x183592560", Slot = "25")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x3592680", Offset = "0x3590C80", VA = "0x183592680")]
		private void Start()
		{
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA8")]
		[Address(RVA = "0x35926F0", Offset = "0x3590CF0", VA = "0x1835926F0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA9")]
		[Address(RVA = "0x3592860", Offset = "0x3590E60", VA = "0x183592860")]
		private void SetTriggered(bool triggered)
		{
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x3592CA0", Offset = "0x35912A0", VA = "0x183592CA0")]
		private void OnTrapTriggered(Collider obj)
		{
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x3592F50", Offset = "0x3591550", VA = "0x183592F50")]
		public void OnTrapTriggeredRemotely()
		{
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x3592F80", Offset = "0x3591580", VA = "0x183592F80", Slot = "26")]
		protected virtual void TriggerTrapAudio()
		{
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00012270 File Offset: 0x00010470
		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "27")]
		protected virtual bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x3593020", Offset = "0x3591620", VA = "0x183593020")]
		public void ResetTrapRemotely()
		{
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x35930F0", Offset = "0x35916F0", VA = "0x1835930F0")]
		public void ResetTrap()
		{
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		protected virtual void OnReset()
		{
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
		public BaseTrapController.SaveData GetSerializedData()
		{
			return null;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x3593240", Offset = "0x3591840", VA = "0x183593240")]
		public void DeserializeData(BaseTrapController.SaveData saveData)
		{
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x3593260", Offset = "0x3591860", VA = "0x183593260")]
		protected BaseTrapController()
		{
		}

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ResetScrewTrap _trapReset;

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private OnTriggerProxy _onTriggerTrapProxy;

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected LayerMask _triggerLayers;

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[FieldOffset(Offset = "0x50")]
		[EventRef]
		[FormerlySerializedAs("_onTriggeredEvent")]
		[SerializeField]
		private string _trapTriggeredSfxEvent;

		// Token: 0x040032AF RID: 12975
		[Token(Token = "0x40032AF")]
		[FieldOffset(Offset = "0x58")]
		[EventRef]
		[FormerlySerializedAs("_onResetEvent")]
		[SerializeField]
		private string _trapResetSfxEvent;

		// Token: 0x040032B0 RID: 12976
		[Token(Token = "0x40032B0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected List<VailActorTypeId> _validActorTypes;

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _triggerIgnoreSmallAnimals;

		// Token: 0x040032B2 RID: 12978
		[Token(Token = "0x40032B2")]
		[FieldOffset(Offset = "0x70")]
		private FMOD_AnimationEventHandler _fmodAnimationEventHandler;

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		[FieldOffset(Offset = "0x78")]
		private readonly BaseTrapController.SaveData _saveData;

		// Token: 0x0200083A RID: 2106
		[Token(Token = "0x200083A")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x06003BB4 RID: 15284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BB4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SaveData()
			{
			}

			// Token: 0x040032B4 RID: 12980
			[Token(Token = "0x40032B4")]
			[FieldOffset(Offset = "0x10")]
			public bool IsTriggered;
		}
	}
}
