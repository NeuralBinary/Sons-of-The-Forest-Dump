using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x020006BB RID: 1723
	[Token(Token = "0x20006BB")]
	public class SluggyStateManager : MonoBehaviour
	{
		// Token: 0x06002C37 RID: 11319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C37")]
		[Address(RVA = "0x2DF8060", Offset = "0x2DF7060", VA = "0x182DF8060")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C38")]
		[Address(RVA = "0x2DF8260", Offset = "0x2DF7260", VA = "0x182DF8260")]
		private void OnValidate()
		{
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x2DF8130", Offset = "0x2DF7130", VA = "0x182DF8130")]
		private void OnEnable()
		{
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x2DF80A0", Offset = "0x2DF70A0", VA = "0x182DF80A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3B")]
		[Address(RVA = "0x2DF8230", Offset = "0x2DF7230", VA = "0x182DF8230")]
		private void OnStateChanged(NamedIntData data)
		{
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0x2DF84D0", Offset = "0x2DF74D0", VA = "0x182DF84D0")]
		public void SluggySpawned()
		{
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x2DF8490", Offset = "0x2DF7490", VA = "0x182DF8490")]
		public void SluggyRevealed()
		{
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3E")]
		[Address(RVA = "0x2DF82F0", Offset = "0x2DF72F0", VA = "0x182DF82F0")]
		private void SetStateValue(SluggyState sluggyState)
		{
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C3F")]
		[Address(RVA = "0x2DF7910", Offset = "0x2DF6910", VA = "0x182DF7910")]
		private void ApplyState(SluggyState currentState)
		{
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C40")]
		[Address(RVA = "0x2DF7C30", Offset = "0x2DF6C30", VA = "0x182DF7C30")]
		private void DoDead(SluggyState lastKnownState)
		{
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C41")]
		[Address(RVA = "0x2DF7E30", Offset = "0x2DF6E30", VA = "0x182DF7E30")]
		private void DoSpawn()
		{
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C42")]
		[Address(RVA = "0x2DF7CF0", Offset = "0x2DF6CF0", VA = "0x182DF7CF0")]
		private void DoReveal()
		{
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C43")]
		[Address(RVA = "0x2DF8330", Offset = "0x2DF7330", VA = "0x182DF8330")]
		private void SluggyKilled()
		{
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C44")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SluggyStateManager()
		{
		}

		// Token: 0x0400279C RID: 10140
		[Token(Token = "0x400279C")]
		private const string RevealedTriggerObjectName = "Trigger";

		// Token: 0x0400279D RID: 10141
		[Token(Token = "0x400279D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _root;

		// Token: 0x0400279E RID: 10142
		[Token(Token = "0x400279E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _blockingRocks;

		// Token: 0x0400279F RID: 10143
		[Token(Token = "0x400279F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _sluggyPrefabSource;

		// Token: 0x040027A0 RID: 10144
		[Token(Token = "0x40027A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _namedIntKey;

		// Token: 0x040027A1 RID: 10145
		[Token(Token = "0x40027A1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SluggyState _startingState;

		// Token: 0x040027A2 RID: 10146
		[Token(Token = "0x40027A2")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _breakRocksTriggerTarget;

		// Token: 0x040027A3 RID: 10147
		[Token(Token = "0x40027A3")]
		[FieldOffset(Offset = "0x50")]
		private SluggyState _lastKnownState;

		// Token: 0x040027A4 RID: 10148
		[Token(Token = "0x40027A4")]
		[FieldOffset(Offset = "0x58")]
		private NamedIntData _state;

		// Token: 0x040027A5 RID: 10149
		[Token(Token = "0x40027A5")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _prefabInstance;

		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		[FieldOffset(Offset = "0x68")]
		private TriggerSluggieKilledEvent _sluggieKilledEvent;

		// Token: 0x040027A7 RID: 10151
		[Token(Token = "0x40027A7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UnityEvent _onRevealEvent;
	}
}
