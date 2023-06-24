using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
[CreateAssetMenu(fileName = "NewPrintedItemBlueprint", menuName = "Sons/3D Printing/PrintedItemBlueprint")]
public class PrintedItemBlueprint : ScriptableObject
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000012")]
	public GameObject PrintedItem
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000013")]
	public string Name
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000FC RID: 252 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x17000014")]
	public Color DefaultColor
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x25AEE50", Offset = "0x25AD450", VA = "0x1825AEE50")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000FD RID: 253 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x17000015")]
	public int RequiredResin
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000FE RID: 254 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x17000016")]
	public float TotalPrintTime
	{
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000017")]
	public Texture IconTexture
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000100 RID: 256 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x17000018")]
	public Vector3 PositionOffset
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1FED010", Offset = "0x1FEB610", VA = "0x181FED010")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000101 RID: 257 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x17000019")]
	public Quaternion RotationOffset
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2D40560", Offset = "0x2D3EB60", VA = "0x182D40560")]
		get
		{
			return default(Quaternion);
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000102 RID: 258 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x1700001A")]
	public Vector3 Scale
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x26FA800", Offset = "0x26F8E00", VA = "0x1826FA800")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000103 RID: 259 RVA: 0x000023E8 File Offset: 0x000005E8
	[Token(Token = "0x1700001B")]
	public float PrintBedHeight
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000104 RID: 260 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x1700001C")]
	public int Id
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xAFF2B0", Offset = "0xAFD8B0", VA = "0x180AFF2B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001D")]
	public List<Vector3> Positions
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2F74270", Offset = "0x2F72870", VA = "0x182F74270")]
	public string GetLocalizedName()
	{
		return null;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2F74460", Offset = "0x2F72A60", VA = "0x182F74460")]
	private void OnValidate()
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2F74470", Offset = "0x2F72A70", VA = "0x182F74470")]
	public PrintedItemBlueprint()
	{
	}

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	private const string ItemsTableReference = "Items";

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _printedItem;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _name;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string _translationKey;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Texture _iconTexture;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color _defaultPrintColor;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int _requiredResinVolume;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _totalPrintTime;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<Vector3> _positions;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _printBedHeight;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private Vector3 _printPlatePositionOffset;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Quaternion _printPlateRotationOffset;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector3 _printPlateScale;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private int _id;
}
