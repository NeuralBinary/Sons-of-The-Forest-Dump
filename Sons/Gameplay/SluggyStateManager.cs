using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x020007F3 RID: 2035
	[Token(Token = "0x20007F3")]
	public class SluggyStateManager : MonoBehaviour
	{
		// Token: 0x06003704 RID: 14084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x3537320", Offset = "0x3535920", VA = "0x183537320")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x3537360", Offset = "0x3535960", VA = "0x183537360")]
		private void OnValidate()
		{
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x35374B0", Offset = "0x3535AB0", VA = "0x1835374B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x3537600", Offset = "0x3535C00", VA = "0x183537600")]
		private void OnDisable()
		{
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x3537690", Offset = "0x3535C90", VA = "0x183537690")]
		private void OnStateChanged(NamedIntData data)
		{
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x35376C0", Offset = "0x3535CC0", VA = "0x1835376C0")]
		public void SluggySpawned()
		{
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x3537740", Offset = "0x3535D40", VA = "0x183537740")]
		public void SluggyRevealed()
		{
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x35377C0", Offset = "0x3535DC0", VA = "0x1835377C0")]
		private void SetStateValue(SluggyState sluggyState)
		{
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x3537830", Offset = "0x3535E30", VA = "0x183537830")]
		private void ApplyState(SluggyState currentState)
		{
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x3537B30", Offset = "0x3536130", VA = "0x183537B30")]
		private void DoDead(SluggyState lastKnownState)
		{
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x3537CE0", Offset = "0x35362E0", VA = "0x183537CE0")]
		private void DoSpawn()
		{
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x35381F0", Offset = "0x35367F0", VA = "0x1835381F0")]
		private void DoReveal()
		{
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x35383C0", Offset = "0x35369C0", VA = "0x1835383C0")]
		private void SluggyKilled()
		{
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SluggyStateManager()
		{
		}

		// Token: 0x04002F84 RID: 12164
		[Token(Token = "0x4002F84")]
		private const string RevealedTriggerObjectName = "Trigger";

		// Token: 0x04002F85 RID: 12165
		[Token(Token = "0x4002F85")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _root;

		// Token: 0x04002F86 RID: 12166
		[Token(Token = "0x4002F86")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _blockingRocks;

		// Token: 0x04002F87 RID: 12167
		[Token(Token = "0x4002F87")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _sluggyPrefabSource;

		// Token: 0x04002F88 RID: 12168
		[Token(Token = "0x4002F88")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _namedIntKey;

		// Token: 0x04002F89 RID: 12169
		[Token(Token = "0x4002F89")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SluggyState _startingState;

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _breakRocksTriggerTarget;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x50")]
		private SluggyState _lastKnownState;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x58")]
		private NamedIntData _state;

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _prefabInstance;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x68")]
		private TriggerSluggieKilledEvent _sluggieKilledEvent;

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UnityEvent _onRevealEvent;
	}
}
