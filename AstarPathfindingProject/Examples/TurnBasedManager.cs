using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Pathfinding.Examples
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_turn_based_manager.php")]
	public class TurnBasedManager : MonoBehaviour
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x64DA00", Offset = "0x64C000", VA = "0x18064DA00")]
		private void Awake()
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x64DAB0", Offset = "0x64C0B0", VA = "0x18064DAB0")]
		private void Update()
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x64DE10", Offset = "0x64C410", VA = "0x18064DE10")]
		private void HandleButtonUnderRay(Ray ray)
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA6")]
		private T GetByRay<T>(Ray ray) where T : class
		{
			return null;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		private void Select(TurnBasedAI unit)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x64E0B0", Offset = "0x64C6B0", VA = "0x18064E0B0")]
		private IEnumerator MoveToNode(TurnBasedAI unit, GraphNode node)
		{
			return null;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x64E210", Offset = "0x64C810", VA = "0x18064E210")]
		private static IEnumerator MoveAlongPath(TurnBasedAI unit, ABPath path, float speed)
		{
			return null;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x64E330", Offset = "0x64C930", VA = "0x18064E330")]
		private void DestroyPossibleMoves()
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x64E540", Offset = "0x64CB40", VA = "0x18064E540")]
		private void GeneratePossibleMoves(TurnBasedAI unit)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x64E9F0", Offset = "0x64CFF0", VA = "0x18064E9F0")]
		public TurnBasedManager()
		{
		}

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x20")]
		private TurnBasedAI selected;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x28")]
		public float movementSpeed;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x30")]
		public GameObject nodePrefab;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x38")]
		public LayerMask layerMask;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x40")]
		private List<GameObject> possibleMoves;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x48")]
		private EventSystem eventSystem;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x50")]
		public TurnBasedManager.State state;

		// Token: 0x02000179 RID: 377
		[Token(Token = "0x2000179")]
		public enum State
		{
			// Token: 0x0400086D RID: 2157
			[Token(Token = "0x400086D")]
			SelectUnit,
			// Token: 0x0400086E RID: 2158
			[Token(Token = "0x400086E")]
			SelectTarget,
			// Token: 0x0400086F RID: 2159
			[Token(Token = "0x400086F")]
			Move
		}
	}
}
