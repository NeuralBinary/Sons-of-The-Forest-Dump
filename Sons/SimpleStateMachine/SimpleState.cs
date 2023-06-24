using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.SimpleStateMachine
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	[Serializable]
	public abstract class SimpleState
	{
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060022F4 RID: 8948
		[Token(Token = "0x170004BA")]
		public abstract string Name { [Token(Token = "0x60022F4")] get; }

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060022F5 RID: 8949 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022F6 RID: 8950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		public event Action OnUpdate
		{
			[Token(Token = "0x60022F5")]
			[Address(RVA = "0x3348120", Offset = "0x3346720", VA = "0x183348120")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022F6")]
			[Address(RVA = "0x3348210", Offset = "0x3346810", VA = "0x183348210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060022F7 RID: 8951 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022F8 RID: 8952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000015")]
		public event Action<SimpleState> OnEnter
		{
			[Token(Token = "0x60022F7")]
			[Address(RVA = "0x3348300", Offset = "0x3346900", VA = "0x183348300")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022F8")]
			[Address(RVA = "0x3348470", Offset = "0x3346A70", VA = "0x183348470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060022F9 RID: 8953 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022FA RID: 8954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000016")]
		public event Action<SimpleState> OnExit
		{
			[Token(Token = "0x60022F9")]
			[Address(RVA = "0x33485E0", Offset = "0x3346BE0", VA = "0x1833485E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022FA")]
			[Address(RVA = "0x3348750", Offset = "0x3346D50", VA = "0x183348750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
		internal float GetLifetime()
		{
			return 0f;
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x33488C0", Offset = "0x3346EC0", VA = "0x1833488C0")]
		internal void Update()
		{
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x3348990", Offset = "0x3346F90", VA = "0x183348990")]
		internal void DoExitTo(SimpleState nextState)
		{
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x3348A20", Offset = "0x3347020", VA = "0x183348A20")]
		internal void DoEnterFrom(SimpleState previousState)
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x3348AF0", Offset = "0x33470F0", VA = "0x183348AF0")]
		private SimpleState.TransitionCheck CreateTransition(Func<bool> transitionCheck, Func<SimpleState> constructorSource)
		{
			return null;
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002300")]
		[Address(RVA = "0x3348CD0", Offset = "0x33472D0", VA = "0x183348CD0")]
		protected void AddTransition(Func<bool> checkFor, Func<SimpleState> constructor)
		{
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x3348E00", Offset = "0x3347400", VA = "0x183348E00")]
		protected void AddTransition(SimpleState.TransitionCheck newTransition)
		{
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x6002302")]
		[Address(RVA = "0x3348F30", Offset = "0x3347530", VA = "0x183348F30")]
		internal bool GetTransitionState(out SimpleState toState)
		{
			return default(bool);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected SimpleState()
		{
		}

		// Token: 0x04001FD5 RID: 8149
		[Token(Token = "0x4001FD5")]
		[FieldOffset(Offset = "0x18")]
		public List<SimpleState.TransitionCheck> Transitions;

		// Token: 0x04001FD8 RID: 8152
		[Token(Token = "0x4001FD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _enterTime;

		// Token: 0x04001FD9 RID: 8153
		[Token(Token = "0x4001FD9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _exitTime;

		// Token: 0x04001FDA RID: 8154
		[Token(Token = "0x4001FDA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _lastUpdateTime;

		// Token: 0x04001FDB RID: 8155
		[Token(Token = "0x4001FDB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private StateMode _stateMode;

		// Token: 0x04001FDC RID: 8156
		[Token(Token = "0x4001FDC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _lifetime;

		// Token: 0x02000523 RID: 1315
		// (Invoke) Token: 0x06002305 RID: 8965
		[Token(Token = "0x2000523")]
		public delegate bool TransitionCheck(out Func<SimpleState> nextStateConstructor);
	}
}
