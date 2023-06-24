using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Environment.Digging.TerrainDig;
using Sons.Gameplay;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Cutscenes
{
	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	public class BuriedCoffinController : MonoBehaviour
	{
		// Token: 0x06002A9A RID: 10906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0x33FE5E0", Offset = "0x33FCBE0", VA = "0x1833FE5E0")]
		private void Update()
		{
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0x33FE6E0", Offset = "0x33FCCE0", VA = "0x1833FE6E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x33FE810", Offset = "0x33FCE10", VA = "0x1833FE810")]
		private void Initialize()
		{
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x33FEB60", Offset = "0x33FD160", VA = "0x1833FEB60")]
		private void TopDigCountChanged(int count)
		{
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x33FEC10", Offset = "0x33FD210", VA = "0x1833FEC10")]
		private void BotDigCountChanged(int count)
		{
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x33FECC0", Offset = "0x33FD2C0", VA = "0x1833FECC0")]
		private void OnBreak()
		{
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x33FEE20", Offset = "0x33FD420", VA = "0x1833FEE20")]
		private void SetActiveObjects(List<GameObject> targetList, bool value)
		{
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x33FF010", Offset = "0x33FD610", VA = "0x1833FF010")]
		private void EnableInteraction()
		{
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x33FF050", Offset = "0x33FD650", VA = "0x1833FF050")]
		private void DisableInteraction()
		{
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x33FF070", Offset = "0x33FD670", VA = "0x1833FF070")]
		public BuriedCoffinController()
		{
		}

		// Token: 0x040025CA RID: 9674
		[Token(Token = "0x40025CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DetectCollisionBlocked _detectBlocked;

		// Token: 0x040025CB RID: 9675
		[Token(Token = "0x40025CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _interactiveGameObjects;

		// Token: 0x040025CC RID: 9676
		[Token(Token = "0x40025CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _openedGameObjects;

		// Token: 0x040025CD RID: 9677
		[Token(Token = "0x40025CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BreakableObject _breakableObject;

		// Token: 0x040025CE RID: 9678
		[Token(Token = "0x40025CE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent _onInitialize;

		// Token: 0x040025CF RID: 9679
		[Token(Token = "0x40025CF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _onInteractive;

		// Token: 0x040025D0 RID: 9680
		[Token(Token = "0x40025D0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent _onComplete;

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TerrainDigDetectionArea _topDigDetectionArea;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _topDigCountActivate;

		// Token: 0x040025D3 RID: 9683
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		private List<GameObject> _topBreakables;

		// Token: 0x040025D4 RID: 9684
		[Token(Token = "0x40025D4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<GameObject> _topBreakActivated;

		// Token: 0x040025D5 RID: 9685
		[Token(Token = "0x40025D5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TerrainDigDetectionArea _botDigDetectionArea;

		// Token: 0x040025D6 RID: 9686
		[Token(Token = "0x40025D6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int _botDigCountActivate;

		// Token: 0x040025D7 RID: 9687
		[Token(Token = "0x40025D7")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		[SerializeField]
		private List<GameObject> _botBreakables;

		// Token: 0x040025D8 RID: 9688
		[Token(Token = "0x40025D8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<GameObject> _botBreakActivated;

		// Token: 0x040025D9 RID: 9689
		[Token(Token = "0x40025D9")]
		[FieldOffset(Offset = "0x98")]
		private CoffinState _state;

		// Token: 0x040025DA RID: 9690
		[Token(Token = "0x40025DA")]
		[FieldOffset(Offset = "0x9C")]
		private bool _isBlocked;

		// Token: 0x040025DB RID: 9691
		[Token(Token = "0x40025DB")]
		[FieldOffset(Offset = "0x9D")]
		private bool _isOpen;

		// Token: 0x040025DC RID: 9692
		[Token(Token = "0x40025DC")]
		[FieldOffset(Offset = "0x9E")]
		private bool _coverBroken;
	}
}
