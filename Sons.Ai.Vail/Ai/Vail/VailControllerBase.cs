using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public abstract class VailControllerBase : ScriptableObject, ISerializationCallbackReceiver
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2B59A50", Offset = "0x2B58050", VA = "0x182B59A50")]
		private void ClearIsolation()
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2B59BB0", Offset = "0x2B581B0", VA = "0x182B59BB0")]
		private void ClearMute()
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2B59D10", Offset = "0x2B58310", VA = "0x182B59D10")]
		private void MuteAll()
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2B59E70", Offset = "0x2B58470", VA = "0x182B59E70")]
		private void SelectInDebugCamera()
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x1700007D")]
		private bool GameIsRunning
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x2B59F10", Offset = "0x2B58510", VA = "0x182B59F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00005940 File Offset: 0x00003B40
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		public static bool IsolationChanged
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x2B59F90", Offset = "0x2B58590", VA = "0x182B59F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x2B59FD0", Offset = "0x2B585D0", VA = "0x182B59FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2B5A010", Offset = "0x2B58610", VA = "0x182B5A010", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2B5A2C0", Offset = "0x2B588C0", VA = "0x182B5A2C0")]
		private void Reset()
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2B5A2D0", Offset = "0x2B588D0", VA = "0x182B5A2D0")]
		public void OnSpawned()
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2B5A410", Offset = "0x2B58A10", VA = "0x182B5A410")]
		internal void OnValidate()
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x2B5A6E0", Offset = "0x2B58CE0", VA = "0x182B5A6E0")]
		private void SetAdjacentGroups()
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2B5AC40", Offset = "0x2B59240", VA = "0x182B5AC40")]
		public bool CheckIsolation(out Group group, out Thought thought)
		{
			return default(bool);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2B5AF20", Offset = "0x2B59520", VA = "0x182B5AF20")]
		public bool Run(VailActor vailActor, Priority currentPriority, Priority interruptPriority, List<Group> nextInSequence)
		{
			return default(bool);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x2B5B000", Offset = "0x2B59600", VA = "0x182B5B000")]
		public bool RunGroup(VailActor vailActor, Group group)
		{
			return default(bool);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x2B5B070", Offset = "0x2B59670", VA = "0x182B5B070")]
		public StateSet GetStateSet(State state)
		{
			return null;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2B5B230", Offset = "0x2B59830", VA = "0x182B5B230")]
		private bool RunAnyStateOverride(VailActor vailActor, Priority currentPriority, Priority interruptPriority, List<Group> nextInSequence)
		{
			return default(bool);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x2B5B460", Offset = "0x2B59A60", VA = "0x182B5B460")]
		public bool HasStateSet(State currentState)
		{
			return default(bool);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x2B5B5C0", Offset = "0x2B59BC0", VA = "0x182B5B5C0")]
		public string GetStatString()
		{
			return null;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x2B5BD70", Offset = "0x2B5A370", VA = "0x182B5BD70")]
		public string GetGroupDriverAndPercent(VailActor actor)
		{
			return null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		protected VailControllerBase()
		{
		}

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x18")]
		private bool _hasIsolation;

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RuntimeAnimatorController _checkAnimator;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<StateSet> _stateSets;
	}
}
