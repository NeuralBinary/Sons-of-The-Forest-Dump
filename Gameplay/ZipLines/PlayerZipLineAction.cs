using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	[AddComponentMenu("Sons/Gameplay/Ziplines/PlayerZipLineAction")]
	public class PlayerZipLineAction : MonoBehaviour
	{
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[Token(Token = "0x17000598")]
		public Vector3 ExitForce
		{
			[Token(Token = "0x6002CA1")]
			[Address(RVA = "0x2298880", Offset = "0x2297880", VA = "0x182298880")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x0000CC60 File Offset: 0x0000AE60
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000599")]
		public bool IsOnZipLine
		{
			[Token(Token = "0x6002CA2")]
			[Address(RVA = "0x86F2C0", Offset = "0x86E2C0", VA = "0x18086F2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CA3")]
			[Address(RVA = "0x86F310", Offset = "0x86E310", VA = "0x18086F310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA4")]
		[Address(RVA = "0x2DE2B50", Offset = "0x2DE1B50", VA = "0x182DE2B50")]
		public void EnterZipLineMode(Transform connectionPoint, ZipLineController zipLineController)
		{
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA5")]
		[Address(RVA = "0x2DE2970", Offset = "0x2DE1970", VA = "0x182DE2970")]
		private void DetachFromZipLine(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA6")]
		[Address(RVA = "0x2DE3360", Offset = "0x2DE2360", VA = "0x182DE3360")]
		public void ExitZipLineMode(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA7")]
		[Address(RVA = "0x2DE3C90", Offset = "0x2DE2C90", VA = "0x182DE3C90")]
		private IEnumerator PreserveExitVelocity(Vector3 exitVelocity)
		{
			return null;
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA8")]
		[Address(RVA = "0x2DE3D20", Offset = "0x2DE2D20", VA = "0x182DE3D20")]
		public PlayerZipLineAction()
		{
		}

		// Token: 0x040027F0 RID: 10224
		[Token(Token = "0x40027F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _connectedHeightOffset;

		// Token: 0x040027F1 RID: 10225
		[Token(Token = "0x40027F1")]
		[FieldOffset(Offset = "0x28")]
		[EventRef]
		[SerializeField]
		private string _zipLineExitEvent;

		// Token: 0x040027F2 RID: 10226
		[Token(Token = "0x40027F2")]
		[FieldOffset(Offset = "0x30")]
		private Animator _animator;

		// Token: 0x040027F3 RID: 10227
		[Token(Token = "0x40027F3")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _exitForce;

		// Token: 0x040027F4 RID: 10228
		[Token(Token = "0x40027F4")]
		[FieldOffset(Offset = "0x48")]
		private ZipLineController _zipLineController;

		// Token: 0x040027F5 RID: 10229
		[Token(Token = "0x40027F5")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _ropeGunInstance;

		// Token: 0x040027F6 RID: 10230
		[Token(Token = "0x40027F6")]
		[FieldOffset(Offset = "0x58")]
		private bool _ignoreDetach;
	}
}
