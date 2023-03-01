using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Areas;
using Sons.Gameplay;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000817 RID: 2071
	[Token(Token = "0x2000817")]
	[AddComponentMenu("Sons/Vail/CaveBoards")]
	[Serializable]
	public class CaveBoards : BoltEntityBehaviourWrapper<ICaveBoardsState>
	{
		// Token: 0x0600371D RID: 14109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x2EB2BA0", Offset = "0x2EB1BA0", VA = "0x182EB2BA0")]
		private void Awake()
		{
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x2EB36B0", Offset = "0x2EB26B0", VA = "0x182EB36B0")]
		private void Start()
		{
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x2EB3080", Offset = "0x2EB2080", VA = "0x182EB3080")]
		private void OnEnable()
		{
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003720")]
		[Address(RVA = "0x2EB37E0", Offset = "0x2EB27E0", VA = "0x182EB37E0")]
		private void Update()
		{
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003721")]
		[Address(RVA = "0x2EB29C0", Offset = "0x2EB19C0", VA = "0x182EB29C0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x6003722")]
		[Address(RVA = "0x2EB2C10", Offset = "0x2EB1C10", VA = "0x182EB2C10")]
		private int GetBoardMask()
		{
			return default(int);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003723")]
		[Address(RVA = "0x2EB3410", Offset = "0x2EB2410", VA = "0x182EB3410")]
		private void ServerUpdate()
		{
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003724")]
		[Address(RVA = "0x2EB2E90", Offset = "0x2EB1E90", VA = "0x182EB2E90")]
		private void OnBoardMaskChanged()
		{
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003725")]
		[Address(RVA = "0x2EB2D40", Offset = "0x2EB1D40", VA = "0x182EB2D40")]
		private void OnAreaMaskChanged()
		{
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003726")]
		[Address(RVA = "0x2EB30C0", Offset = "0x2EB20C0", VA = "0x182EB30C0")]
		private void ServerCheckCaveOpened()
		{
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x2EB31B0", Offset = "0x2EB21B0", VA = "0x182EB31B0")]
		public void ServerReceivedCaveBoardBroken(CaveBoardBroken evnt)
		{
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003728")]
		[Address(RVA = "0x2EB2DB0", Offset = "0x2EB1DB0", VA = "0x182EB2DB0")]
		private void OnBoardBroken()
		{
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x2EB2BC0", Offset = "0x2EB1BC0", VA = "0x182EB2BC0")]
		private void CollectChildren()
		{
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x2EB3840", Offset = "0x2EB2840", VA = "0x182EB3840")]
		public CaveBoards()
		{
		}

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x30")]
		private int _boardMask;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x34")]
		private bool _isCaveOpen;

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AreaMask _caveAreaMask;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x40")]
		[EventRef]
		[SerializeField]
		private string _onOpenEvent;

		// Token: 0x04002F37 RID: 12087
		[Token(Token = "0x4002F37")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BreakableObject[] _boards;
	}
}
