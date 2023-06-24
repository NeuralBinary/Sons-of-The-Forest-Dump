using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	[CreateAssetMenu(menuName = "Sons/Ai/WorldSimController", fileName = "WorldSimController", order = 0)]
	public class WorldSimController : ScriptableObject
	{
		// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x2B8C6E0", Offset = "0x2B8ACE0", VA = "0x182B8C6E0")]
		public void AddMove()
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x2B8C7A0", Offset = "0x2B8ADA0", VA = "0x182B8C7A0")]
		public void AddHold()
		{
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x2B8C8C0", Offset = "0x2B8AEC0", VA = "0x182B8C8C0")]
		public void AddTeleport()
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x2B8C980", Offset = "0x2B8AF80", VA = "0x182B8C980")]
		public void AddGuard()
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ShowOptionChances()
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x2B8CA40", Offset = "0x2B8B040", VA = "0x182B8CA40")]
		private void BeginListItem(int opt)
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x2B8CAB0", Offset = "0x2B8B0B0", VA = "0x182B8CAB0")]
		private void EndListItem(int opt)
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x2B8CB20", Offset = "0x2B8B120", VA = "0x182B8CB20")]
		public void ChooseAction(VailWorldSimulation worldSim, WorldSimActor actor)
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public WorldSimController()
		{
		}

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x18")]
		[SerializeReference]
		private List<WorldSimAction> _actions;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<int> _validActions;
	}
}
