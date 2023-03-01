using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Environment.Digging.TerrainDig;
using Sons.Gameplay;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Cutscenes
{
	// Token: 0x0200075A RID: 1882
	[Token(Token = "0x200075A")]
	public class BuriedCoffinController : MonoBehaviour
	{
		// Token: 0x06003125 RID: 12581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x2E3C400", Offset = "0x2E3B400", VA = "0x182E3C400")]
		private void Update()
		{
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x2E3C120", Offset = "0x2E3B120", VA = "0x182E3C120")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x2E3BDE0", Offset = "0x2E3ADE0", VA = "0x182E3BDE0")]
		private void Initialize()
		{
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x2E3C350", Offset = "0x2E3B350", VA = "0x182E3C350")]
		private void TopDigCountChanged(int count)
		{
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003129")]
		[Address(RVA = "0x2E3BCD0", Offset = "0x2E3ACD0", VA = "0x182E3BCD0")]
		private void BotDigCountChanged(int count)
		{
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x2E3C020", Offset = "0x2E3B020", VA = "0x182E3C020")]
		private void OnBreak()
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312B")]
		[Address(RVA = "0x2E3C1F0", Offset = "0x2E3B1F0", VA = "0x182E3C1F0")]
		private void SetActiveObjects(List<GameObject> targetList, bool value)
		{
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312C")]
		[Address(RVA = "0x2E3BDA0", Offset = "0x2E3ADA0", VA = "0x182E3BDA0")]
		private void EnableInteraction()
		{
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312D")]
		[Address(RVA = "0x2E3BD80", Offset = "0x2E3AD80", VA = "0x182E3BD80")]
		private void DisableInteraction()
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600312E")]
		[Address(RVA = "0x2E3C500", Offset = "0x2E3B500", VA = "0x182E3C500")]
		public BuriedCoffinController()
		{
		}

		// Token: 0x04002AF9 RID: 11001
		[Token(Token = "0x4002AF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DetectCollisionBlocked _detectBlocked;

		// Token: 0x04002AFA RID: 11002
		[Token(Token = "0x4002AFA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _interactiveGameObjects;

		// Token: 0x04002AFB RID: 11003
		[Token(Token = "0x4002AFB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _openedGameObjects;

		// Token: 0x04002AFC RID: 11004
		[Token(Token = "0x4002AFC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BreakableObject _breakableObject;

		// Token: 0x04002AFD RID: 11005
		[Token(Token = "0x4002AFD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent _onInitialize;

		// Token: 0x04002AFE RID: 11006
		[Token(Token = "0x4002AFE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _onInteractive;

		// Token: 0x04002AFF RID: 11007
		[Token(Token = "0x4002AFF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent _onComplete;

		// Token: 0x04002B00 RID: 11008
		[Token(Token = "0x4002B00")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TerrainDigDetectionArea _topDigDetectionArea;

		// Token: 0x04002B01 RID: 11009
		[Token(Token = "0x4002B01")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _topDigCountActivate;

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private List<GameObject> _topBreakables;

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<GameObject> _topBreakActivated;

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TerrainDigDetectionArea _botDigDetectionArea;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int _botDigCountActivate;

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[HideInInspector]
		private List<GameObject> _botBreakables;

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<GameObject> _botBreakActivated;

		// Token: 0x04002B08 RID: 11016
		[Token(Token = "0x4002B08")]
		[FieldOffset(Offset = "0x98")]
		private CoffinState _state;

		// Token: 0x04002B09 RID: 11017
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x9C")]
		private bool _isBlocked;

		// Token: 0x04002B0A RID: 11018
		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0x9D")]
		private bool _isOpen;

		// Token: 0x04002B0B RID: 11019
		[Token(Token = "0x4002B0B")]
		[FieldOffset(Offset = "0x9E")]
		private bool _coverBroken;
	}
}
