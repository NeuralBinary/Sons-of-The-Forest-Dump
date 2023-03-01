using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	[Serializable]
	public abstract class SimpleState
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06002207 RID: 8711
		[Token(Token = "0x170004A6")]
		public abstract string Name
		{
			[Token(Token = "0x6002207")]
			get;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06002208 RID: 8712 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002209 RID: 8713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000011")]
		public event Action OnUpdate
		{
			[Token(Token = "0x6002208")]
			[Address(RVA = "0x2D6A0B0", Offset = "0x2D690B0", VA = "0x182D6A0B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002209")]
			[Address(RVA = "0x2D6A2B0", Offset = "0x2D692B0", VA = "0x182D6A2B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600220A RID: 8714 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600220B RID: 8715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		public event Action<SimpleState> OnEnter
		{
			[Token(Token = "0x600220A")]
			[Address(RVA = "0x2D69F50", Offset = "0x2D68F50", VA = "0x182D69F50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600220B")]
			[Address(RVA = "0x2D6A150", Offset = "0x2D69150", VA = "0x182D6A150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600220C RID: 8716 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600220D RID: 8717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public event Action<SimpleState> OnExit
		{
			[Token(Token = "0x600220C")]
			[Address(RVA = "0x2D6A000", Offset = "0x2D69000", VA = "0x182D6A000")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600220D")]
			[Address(RVA = "0x2D6A200", Offset = "0x2D69200", VA = "0x182D6A200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00009E88 File Offset: 0x00008088
		[Token(Token = "0x600220E")]
		[Address(RVA = "0x6C5560", Offset = "0x6C4560", VA = "0x1806C5560")]
		internal float GetLifetime()
		{
			return default(float);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600220F")]
		[Address(RVA = "0x2D69EF0", Offset = "0x2D68EF0", VA = "0x182D69EF0")]
		internal void Update()
		{
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002210")]
		[Address(RVA = "0x2D69CF0", Offset = "0x2D68CF0", VA = "0x182D69CF0")]
		internal void DoExitTo(SimpleState nextState)
		{
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002211")]
		[Address(RVA = "0x2D69C90", Offset = "0x2D68C90", VA = "0x182D69C90")]
		internal void DoEnterFrom(SimpleState previousState)
		{
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002212")]
		[Address(RVA = "0x2D69B60", Offset = "0x2D68B60", VA = "0x182D69B60")]
		private SimpleState.TransitionCheck CreateTransition(Func<bool> transitionCheck, Func<SimpleState> constructorSource)
		{
			return null;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002213")]
		[Address(RVA = "0x2D69950", Offset = "0x2D68950", VA = "0x182D69950")]
		protected void AddTransition(Func<bool> checkFor, Func<SimpleState> constructor)
		{
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002214")]
		[Address(RVA = "0x2D69850", Offset = "0x2D68850", VA = "0x182D69850")]
		protected void AddTransition(SimpleState.TransitionCheck newTransition)
		{
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x2D69D50", Offset = "0x2D68D50", VA = "0x182D69D50")]
		internal bool GetTransitionState(out SimpleState toState)
		{
			return default(bool);
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002216")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		protected SimpleState()
		{
		}

		// Token: 0x04001F21 RID: 7969
		[Token(Token = "0x4001F21")]
		[FieldOffset(Offset = "0x18")]
		public List<SimpleState.TransitionCheck> Transitions;

		// Token: 0x04001F24 RID: 7972
		[Token(Token = "0x4001F24")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _enterTime;

		// Token: 0x04001F25 RID: 7973
		[Token(Token = "0x4001F25")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _exitTime;

		// Token: 0x04001F26 RID: 7974
		[Token(Token = "0x4001F26")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _lastUpdateTime;

		// Token: 0x04001F27 RID: 7975
		[Token(Token = "0x4001F27")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private StateMode _stateMode;

		// Token: 0x04001F28 RID: 7976
		[Token(Token = "0x4001F28")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _lifetime;

		// Token: 0x0200051B RID: 1307
		// (Invoke) Token: 0x06002218 RID: 8728
		[Token(Token = "0x200051B")]
		public delegate bool TransitionCheck(out Func<SimpleState> nextStateConstructor);
	}
}
