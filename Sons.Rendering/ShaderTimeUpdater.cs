using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class ShaderTimeUpdater : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x31253B0", Offset = "0x31239B0", VA = "0x1831253B0")]
	private void Awake()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3125660", Offset = "0x3123C60", VA = "0x183125660")]
	private void RemoveDuplicateInstance()
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x31256B0", Offset = "0x3123CB0", VA = "0x1831256B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3125770", Offset = "0x3123D70", VA = "0x183125770")]
	private void Update()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3125890", Offset = "0x3123E90", VA = "0x183125890")]
	private void SetValue()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3125940", Offset = "0x3123F40", VA = "0x183125940")]
	public static void Initialize()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x3125A40", Offset = "0x3124040", VA = "0x183125A40")]
	private static void FindOrCreateInstance()
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x3125D90", Offset = "0x3124390", VA = "0x183125D90")]
	private static void CreateInstance()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3125F30", Offset = "0x3124530", VA = "0x183125F30")]
	private static ShaderTimeUpdater FindInstance()
	{
		return null;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x3125F90", Offset = "0x3124590", VA = "0x183125F90")]
	public ShaderTimeUpdater()
	{
	}

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _disableEditorUpdate;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x21")]
	private bool _hasRunEditorUpdate;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _loopTime;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _currentTime;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x0")]
	private static ShaderTimeUpdater _instance;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x2C")]
	private bool _duplicate;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int RenderedTimeId;
}
