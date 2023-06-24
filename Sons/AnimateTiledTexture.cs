using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
public class AnimateTiledTexture : MonoBehaviour
{
	// Token: 0x06000D59 RID: 3417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x37000B0", Offset = "0x36FE6B0", VA = "0x1837000B0")]
	public void RegisterCallback(AnimateTiledTexture.VoidEvent cbFunction)
	{
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x3700190", Offset = "0x36FE790", VA = "0x183700190")]
	public void UnRegisterCallback(AnimateTiledTexture.VoidEvent cbFunction)
	{
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0x3700230", Offset = "0x36FE830", VA = "0x183700230")]
	public void Play()
	{
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x3700310", Offset = "0x36FE910", VA = "0x183700310")]
	public void ChangeMaterial(Material newMaterial)
	{
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x37006E0", Offset = "0x36FECE0", VA = "0x1837006E0")]
	private Renderer GetRenderer()
	{
		return null;
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x3700720", Offset = "0x36FED20", VA = "0x183700720")]
	private void Awake()
	{
	}

	// Token: 0x06000D5F RID: 3423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x3700850", Offset = "0x36FEE50", VA = "0x183700850")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x3700930", Offset = "0x36FEF30", VA = "0x183700930")]
	private static void HandleCallbacks(IEnumerable<AnimateTiledTexture.VoidEvent> cbList)
	{
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x3700AF0", Offset = "0x36FF0F0", VA = "0x183700AF0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x3700C30", Offset = "0x36FF230", VA = "0x183700C30")]
	private void CalcTextureSize()
	{
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x3700CA0", Offset = "0x36FF2A0", VA = "0x183700CA0")]
	private IEnumerator UpdateTiling()
	{
		return null;
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x3700D30", Offset = "0x36FF330", VA = "0x183700D30")]
	private void ApplyOffset()
	{
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x3700EB0", Offset = "0x36FF4B0", VA = "0x183700EB0")]
	public AnimateTiledTexture()
	{
	}

	// Token: 0x04000C2E RID: 3118
	[Token(Token = "0x4000C2E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _columns;

	// Token: 0x04000C2F RID: 3119
	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _rows;

	// Token: 0x04000C30 RID: 3120
	[Token(Token = "0x4000C30")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 _scale;

	// Token: 0x04000C31 RID: 3121
	[Token(Token = "0x4000C31")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 _offset;

	// Token: 0x04000C32 RID: 3122
	[Token(Token = "0x4000C32")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector2 _buffer;

	// Token: 0x04000C33 RID: 3123
	[Token(Token = "0x4000C33")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _framesPerSecond;

	// Token: 0x04000C34 RID: 3124
	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _playOnce;

	// Token: 0x04000C35 RID: 3125
	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	private bool _disableUponCompletion;

	// Token: 0x04000C36 RID: 3126
	[Token(Token = "0x4000C36")]
	[FieldOffset(Offset = "0x46")]
	[SerializeField]
	private bool _enableEvents;

	// Token: 0x04000C37 RID: 3127
	[Token(Token = "0x4000C37")]
	[FieldOffset(Offset = "0x47")]
	[SerializeField]
	private bool _playOnEnable;

	// Token: 0x04000C38 RID: 3128
	[Token(Token = "0x4000C38")]
	[FieldOffset(Offset = "0x48")]
	private int _index;

	// Token: 0x04000C39 RID: 3129
	[Token(Token = "0x4000C39")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 _textureSize;

	// Token: 0x04000C3A RID: 3130
	[Token(Token = "0x4000C3A")]
	[FieldOffset(Offset = "0x58")]
	private Material _materialInstance;

	// Token: 0x04000C3B RID: 3131
	[Token(Token = "0x4000C3B")]
	[FieldOffset(Offset = "0x60")]
	private bool _isPlaying;

	// Token: 0x04000C3C RID: 3132
	[Token(Token = "0x4000C3C")]
	[FieldOffset(Offset = "0x68")]
	private List<AnimateTiledTexture.VoidEvent> _voidEventCallbackList;

	// Token: 0x04000C3D RID: 3133
	[Token(Token = "0x4000C3D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int MainTex;

	// Token: 0x020001CD RID: 461
	// (Invoke) Token: 0x06000D68 RID: 3432
	[Token(Token = "0x20001CD")]
	public delegate void VoidEvent();
}
