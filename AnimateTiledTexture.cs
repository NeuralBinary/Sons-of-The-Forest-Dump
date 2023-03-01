using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CD RID: 461
[Token(Token = "0x20001CD")]
public class AnimateTiledTexture : MonoBehaviour
{
	// Token: 0x06000CFE RID: 3326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x2F7D4C0", Offset = "0x2F7C4C0", VA = "0x182F7D4C0")]
	public void RegisterCallback(AnimateTiledTexture.VoidEvent cbFunction)
	{
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x2F7D5C0", Offset = "0x2F7C5C0", VA = "0x182F7D5C0")]
	public void UnRegisterCallback(AnimateTiledTexture.VoidEvent cbFunction)
	{
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x2F7D3A0", Offset = "0x2F7C3A0", VA = "0x182F7D3A0")]
	public void Play()
	{
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x2F7CD60", Offset = "0x2F7BD60", VA = "0x182F7CD60")]
	public void ChangeMaterial(Material newMaterial)
	{
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x2F7CF80", Offset = "0x2F7BF80", VA = "0x182F7CF80")]
	private Renderer GetRenderer()
	{
		return null;
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x2F7CC30", Offset = "0x2F7BC30", VA = "0x182F7CC30")]
	private void Awake()
	{
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x2F7D180", Offset = "0x2F7C180", VA = "0x182F7D180")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x2F7CFC0", Offset = "0x2F7BFC0", VA = "0x182F7CFC0")]
	private static void HandleCallbacks(IEnumerable<AnimateTiledTexture.VoidEvent> cbList)
	{
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x2F7D210", Offset = "0x2F7C210", VA = "0x182F7D210")]
	private void OnEnable()
	{
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x2F7CCF0", Offset = "0x2F7BCF0", VA = "0x182F7CCF0")]
	private void CalcTextureSize()
	{
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x2F7D660", Offset = "0x2F7C660", VA = "0x182F7D660")]
	private IEnumerator UpdateTiling()
	{
		return null;
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x2F7CA40", Offset = "0x2F7BA40", VA = "0x182F7CA40")]
	private void ApplyOffset()
	{
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x2F7D720", Offset = "0x2F7C720", VA = "0x182F7D720")]
	public AnimateTiledTexture()
	{
	}

	// Token: 0x04000BFF RID: 3071
	[Token(Token = "0x4000BFF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _columns;

	// Token: 0x04000C00 RID: 3072
	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _rows;

	// Token: 0x04000C01 RID: 3073
	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 _scale;

	// Token: 0x04000C02 RID: 3074
	[Token(Token = "0x4000C02")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 _offset;

	// Token: 0x04000C03 RID: 3075
	[Token(Token = "0x4000C03")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector2 _buffer;

	// Token: 0x04000C04 RID: 3076
	[Token(Token = "0x4000C04")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _framesPerSecond;

	// Token: 0x04000C05 RID: 3077
	[Token(Token = "0x4000C05")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _playOnce;

	// Token: 0x04000C06 RID: 3078
	[Token(Token = "0x4000C06")]
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	private bool _disableUponCompletion;

	// Token: 0x04000C07 RID: 3079
	[Token(Token = "0x4000C07")]
	[FieldOffset(Offset = "0x46")]
	[SerializeField]
	private bool _enableEvents;

	// Token: 0x04000C08 RID: 3080
	[Token(Token = "0x4000C08")]
	[FieldOffset(Offset = "0x47")]
	[SerializeField]
	private bool _playOnEnable;

	// Token: 0x04000C09 RID: 3081
	[Token(Token = "0x4000C09")]
	[FieldOffset(Offset = "0x48")]
	private int _index;

	// Token: 0x04000C0A RID: 3082
	[Token(Token = "0x4000C0A")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 _textureSize;

	// Token: 0x04000C0B RID: 3083
	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0x58")]
	private Material _materialInstance;

	// Token: 0x04000C0C RID: 3084
	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x60")]
	private bool _isPlaying;

	// Token: 0x04000C0D RID: 3085
	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0x68")]
	private List<AnimateTiledTexture.VoidEvent> _voidEventCallbackList;

	// Token: 0x04000C0E RID: 3086
	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int MainTex;

	// Token: 0x020001CE RID: 462
	// (Invoke) Token: 0x06000D0D RID: 3341
	[Token(Token = "0x20001CE")]
	public delegate void VoidEvent();
}
