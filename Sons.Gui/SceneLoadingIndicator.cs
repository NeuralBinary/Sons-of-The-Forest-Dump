using System;
using Il2CppDummyDll;
using Sons.Loading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[AddComponentMenu("Sons/Gui/Scene Loading indicator")]
	public class SceneLoadingIndicator : SceneLoadingListener
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x30166D0", Offset = "0x3014CD0", VA = "0x1830166D0")]
		private void Update()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x3016890", Offset = "0x3014E90", VA = "0x183016890", Slot = "7")]
		public override void OnEnable()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x30168C0", Offset = "0x3014EC0", VA = "0x1830168C0", Slot = "11")]
		public override void UpdateProgress(float progress)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x30168D0", Offset = "0x3014ED0", VA = "0x1830168D0", Slot = "12")]
		public override void UpdateInfo(string message)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x30169C0", Offset = "0x3014FC0", VA = "0x1830169C0")]
		private void SetGoal(float progress)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3016B70", Offset = "0x3015170", VA = "0x183016B70", Slot = "10")]
		public override void Completed()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x3016B80", Offset = "0x3015180", VA = "0x183016B80")]
		public SceneLoadingIndicator()
		{
		}

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _image;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _speed;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _progressOffset;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _invert;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _onlyPositiveProgress;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TMP_Text _percentageText;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TMP_Text _infoText;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x60")]
		private float _goal;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x64")]
		private float _lastAmount;
	}
}
