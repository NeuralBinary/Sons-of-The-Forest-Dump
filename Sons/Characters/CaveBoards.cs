using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Areas;
using Sons.Gameplay;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x0200072A RID: 1834
	[Token(Token = "0x200072A")]
	[AddComponentMenu("Sons/Vail/CaveBoards")]
	[Serializable]
	public class CaveBoards : BoltEntityBehaviourWrapper<ICaveBoardsState>
	{
		// Token: 0x060030F8 RID: 12536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F8")]
		[Address(RVA = "0x3481DD0", Offset = "0x34803D0", VA = "0x183481DD0")]
		private void Awake()
		{
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F9")]
		[Address(RVA = "0x3481DF0", Offset = "0x34803F0", VA = "0x183481DF0")]
		private void Start()
		{
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FA")]
		[Address(RVA = "0x3481F80", Offset = "0x3480580", VA = "0x183481F80")]
		private void OnEnable()
		{
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FB")]
		[Address(RVA = "0x3481FC0", Offset = "0x34805C0", VA = "0x183481FC0")]
		private void Update()
		{
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FC")]
		[Address(RVA = "0x3482050", Offset = "0x3480650", VA = "0x183482050", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x60030FD")]
		[Address(RVA = "0x34822F0", Offset = "0x34808F0", VA = "0x1834822F0")]
		private int GetBoardMask()
		{
			return 0;
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FE")]
		[Address(RVA = "0x3482480", Offset = "0x3480A80", VA = "0x183482480")]
		private void ServerUpdate()
		{
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FF")]
		[Address(RVA = "0x3482830", Offset = "0x3480E30", VA = "0x183482830")]
		private void OnBoardMaskChanged()
		{
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003100")]
		[Address(RVA = "0x3482AF0", Offset = "0x34810F0", VA = "0x183482AF0")]
		private void OnAreaMaskChanged()
		{
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003101")]
		[Address(RVA = "0x3482B90", Offset = "0x3481190", VA = "0x183482B90")]
		private void ServerCheckCaveOpened()
		{
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003102")]
		[Address(RVA = "0x3482CB0", Offset = "0x34812B0", VA = "0x183482CB0")]
		public void ServerReceivedCaveBoardBroken(CaveBoardBroken evnt)
		{
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x3482DC0", Offset = "0x34813C0", VA = "0x183482DC0")]
		private void OnBoardBroken()
		{
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x3482F50", Offset = "0x3481550", VA = "0x183482F50")]
		private void CollectChildren()
		{
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003105")]
		[Address(RVA = "0x3482FF0", Offset = "0x34815F0", VA = "0x183482FF0")]
		public CaveBoards()
		{
		}

		// Token: 0x04002A51 RID: 10833
		[Token(Token = "0x4002A51")]
		[FieldOffset(Offset = "0x30")]
		private int _boardMask;

		// Token: 0x04002A52 RID: 10834
		[Token(Token = "0x4002A52")]
		[FieldOffset(Offset = "0x34")]
		private bool _isCaveOpen;

		// Token: 0x04002A53 RID: 10835
		[Token(Token = "0x4002A53")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AreaMask _caveAreaMask;

		// Token: 0x04002A54 RID: 10836
		[Token(Token = "0x4002A54")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[EventRef]
		private string _onOpenEvent;

		// Token: 0x04002A55 RID: 10837
		[Token(Token = "0x4002A55")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BreakableObject[] _boards;
	}
}
