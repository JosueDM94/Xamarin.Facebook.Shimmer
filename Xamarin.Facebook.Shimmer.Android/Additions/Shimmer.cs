﻿using Android.Runtime;

namespace Facebook.Shimmer
{
    public partial class Shimmer : global::Java.Lang.Object
    {
        public partial class AlphaHighlightBuilder : global::Facebook.Shimmer.Shimmer.Builder
        {
            // Error CS0534: 'Shimmer.AlphaHighlightBuilder' does not implement inherited abstract member 'Shimmer.Builder.RawThis.get'
            protected override Java.Lang.Object RawThis 
                => new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "getThis", "()Lcom/facebook/shimmer/Shimmer$Builder;")), JniHandleOwnership.TransferLocalRef);
        }

        public partial class ColorHighlightBuilder : global::Facebook.Shimmer.Shimmer.Builder
        {
            // Error CS0534: 'Shimmer.AlphaHighlightBuilder' does not implement inherited abstract member 'Shimmer.Builder.RawThis.get'
            protected override Java.Lang.Object RawThis
                => new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "getThis", "()Lcom/facebook/shimmer/Shimmer$Builder;")), JniHandleOwnership.TransferLocalRef);
        }
    }
}