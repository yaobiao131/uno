// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
	[global::Uno.NotImplemented]
#endif
	public partial interface IAudioNode : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		bool ConsumeInput
		{
			get;
			set;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::System.Collections.Generic.IList<global::Windows.Media.Effects.IAudioEffectDefinition> EffectDefinitions
		{
			get;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.Media.MediaProperties.AudioEncodingProperties EncodingProperties
		{
			get;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		double OutgoingGain
		{
			get;
			set;
		}
#endif
		// Forced skipping of method Windows.Media.Audio.IAudioNode.EffectDefinitions.get
		// Forced skipping of method Windows.Media.Audio.IAudioNode.OutgoingGain.set
		// Forced skipping of method Windows.Media.Audio.IAudioNode.OutgoingGain.get
		// Forced skipping of method Windows.Media.Audio.IAudioNode.EncodingProperties.get
		// Forced skipping of method Windows.Media.Audio.IAudioNode.ConsumeInput.get
		// Forced skipping of method Windows.Media.Audio.IAudioNode.ConsumeInput.set
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void Start();
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void Stop();
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void Reset();
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void DisableEffectsByDefinition(global::Windows.Media.Effects.IAudioEffectDefinition definition);
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void EnableEffectsByDefinition(global::Windows.Media.Effects.IAudioEffectDefinition definition);
#endif
	}
}
