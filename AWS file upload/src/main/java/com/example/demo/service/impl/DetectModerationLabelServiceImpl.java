package com.example.demo.service.impl;

import com.amazonaws.auth.AWSCredentials;
import com.amazonaws.auth.AWSStaticCredentialsProvider;
import com.amazonaws.auth.BasicAWSCredentials;
import com.amazonaws.regions.Regions;
import com.amazonaws.services.rekognition.AmazonRekognition;
import com.amazonaws.services.rekognition.AmazonRekognitionClientBuilder;
import com.amazonaws.services.rekognition.model.DetectModerationLabelsRequest;
import com.amazonaws.services.rekognition.model.DetectModerationLabelsResult;
import com.amazonaws.services.rekognition.model.Image;
import com.amazonaws.services.rekognition.model.ModerationLabel;
import com.example.demo.service.DetectModerationLabelService;
import org.springframework.stereotype.Service;

import java.nio.ByteBuffer;
import java.util.List;

@Service
public class DetectModerationLabelServiceImpl implements DetectModerationLabelService {

    @Override
    public List<ModerationLabel> getModerationLabels(byte[] bytes) {
        AWSCredentials credentials = new BasicAWSCredentials("accessKey", "secretKey");
        AmazonRekognition rekognition = AmazonRekognitionClientBuilder.standard().withRegion(Regions.EU_WEST_1).withCredentials(new AWSStaticCredentialsProvider(credentials))
                .build();
        ByteBuffer byteBuffer = ByteBuffer.wrap(bytes);
        DetectModerationLabelsRequest request = new DetectModerationLabelsRequest().withImage(new Image().withBytes(byteBuffer)).withMinConfidence(80F);
        DetectModerationLabelsResult result = rekognition.detectModerationLabels(request);
        return result.getModerationLabels();

    }
}
