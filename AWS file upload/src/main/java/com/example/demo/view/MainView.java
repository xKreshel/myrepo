package com.example.demo.view;

import com.amazonaws.services.rekognition.model.ModerationLabel;
import com.example.demo.service.DetectModerationLabelService;
import com.vaadin.flow.component.notification.Notification;
import com.vaadin.flow.component.orderedlayout.VerticalLayout;
import com.vaadin.flow.component.upload.Upload;
import com.vaadin.flow.component.upload.receivers.MemoryBuffer;
import com.vaadin.flow.router.Route;
import org.apache.commons.io.IOUtils;
import org.springframework.beans.factory.annotation.Autowired;

import javax.annotation.PostConstruct;
import java.io.IOException;
import java.util.List;

@Route
public class MainView extends VerticalLayout {

    @Autowired
    private DetectModerationLabelService detectModerationLabelService;

    @PostConstruct
    private void init() {

        MemoryBuffer buffer = new MemoryBuffer();
        Upload upload = new Upload(buffer);
        upload.setMaxFiles(1);
        upload.addSucceededListener(event -> {
            try {
                List<ModerationLabel> moderationLabelList = detectModerationLabelService.getModerationLabels(IOUtils.toByteArray(buffer.getInputStream()));

                if (moderationLabelList.isEmpty()) {
                    Notification.show("Nothing wrong", 5000, Notification.Position.TOP_END);
                } else {
                    moderationLabelList.forEach(moderationLabel -> Notification.show("Moderation label: " + moderationLabel.getName(), 5000, Notification.Position.TOP_END));
                }

            } catch (IOException e) {
                Notification.show(":(", 5000, Notification.Position.TOP_END);
            }
        });
        add(upload);
    }

}
