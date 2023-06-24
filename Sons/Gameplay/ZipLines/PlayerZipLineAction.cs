using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x0200081F RID: 2079
	[Token(Token = "0x200081F")]
	[AddComponentMenu("Sons/Gameplay/Ziplines/PlayerZipLineAction")]
	public class PlayerZipLineAction : MonoBehaviour
	{
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x00011E98 File Offset: 0x00010098
		[Token(Token = "0x1700079B")]
		public Vector3 ExitForce
		{
			[Token(Token = "0x6003A84")]
			[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x00011EB0 File Offset: 0x000100B0
		// (set) Token: 0x06003A86 RID: 14982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700079C")]
		public bool IsOnZipLine
		{
			[Token(Token = "0x6003A85")]
			[Address(RVA = "0x998F20", Offset = "0x997520", VA = "0x180998F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A86")]
			[Address(RVA = "0x998F30", Offset = "0x997530", VA = "0x180998F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A87")]
		[Address(RVA = "0x3571E70", Offset = "0x3570470", VA = "0x183571E70")]
		public void EnterZipLineMode(Transform connectionPoint, ZipLineController zipLineController)
		{
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A88")]
		[Address(RVA = "0x3573260", Offset = "0x3571860", VA = "0x183573260")]
		private void DetachFromZipLine(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A89")]
		[Address(RVA = "0x3573460", Offset = "0x3571A60", VA = "0x183573460")]
		public void ExitZipLineMode(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x3573FF0", Offset = "0x35725F0", VA = "0x183573FF0")]
		private IEnumerator PreserveExitVelocity(Vector3 exitVelocity)
		{
			return null;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x35740A0", Offset = "0x35726A0", VA = "0x1835740A0")]
		public PlayerZipLineAction()
		{
		}

		// Token: 0x040031CE RID: 12750
		[Token(Token = "0x40031CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _connectedHeightOffset;

		// Token: 0x040031CF RID: 12751
		[Token(Token = "0x40031CF")]
		[FieldOffset(Offset = "0x28")]
		[EventRef]
		[SerializeField]
		private string _zipLineExitEvent;

		// Token: 0x040031D0 RID: 12752
		[Token(Token = "0x40031D0")]
		[FieldOffset(Offset = "0x30")]
		private Animator _animator;

		// Token: 0x040031D1 RID: 12753
		[Token(Token = "0x40031D1")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _exitForce;

		// Token: 0x040031D2 RID: 12754
		[Token(Token = "0x40031D2")]
		[FieldOffset(Offset = "0x48")]
		private ZipLineController _zipLineController;

		// Token: 0x040031D3 RID: 12755
		[Token(Token = "0x40031D3")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _ropeGunInstance;

		// Token: 0x040031D4 RID: 12756
		[Token(Token = "0x40031D4")]
		[FieldOffset(Offset = "0x58")]
		private bool _ignoreDetach;
	}
}
