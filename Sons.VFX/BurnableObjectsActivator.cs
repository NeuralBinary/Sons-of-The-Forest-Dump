using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Interfaces;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
[AddComponentMenu("Sons/Burnable Objects Activator")]
public class BurnableObjectsActivator : MonoBehaviour, IBurnable
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600000C RID: 12 RVA: 0x00002054 File Offset: 0x00000254
	// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	public bool IsBurning
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3161E40", Offset = "0x3160440", VA = "0x183161E40", Slot = "5")]
	public void Burn()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3161E50", Offset = "0x3160450", VA = "0x183161E50")]
	public void Burn(bool enable)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3161FD0", Offset = "0x31605D0", VA = "0x183161FD0")]
	public BurnableObjectsActivator()
	{
	}

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> _objectsToActivate;
}
